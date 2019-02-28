using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;


namespace Calculator.HistoryRepository
{





    public class History
    {
        public SqlConnection Connection { get; }

        public History()
        {
            Connection = new SqlConnection("Data Source = HYPER2\\MISC; Initial Catalog = CalculatorHistory; User ID = SA1; Password = 111");
            Connection.Open();
        }


        public void AddRecord(string condition, double result)
        {
            using (SqlCommand cmd = new SqlCommand("INSERT INTO History(Condition,Result,DateTime,Login,HostName) VALUES(@condition,@result,@dateTime,@login,@hostName)", Connection))
            {
                cmd.Parameters.Add("@condition", SqlDbType.NVarChar).Value = condition;
                cmd.Parameters.Add("@result", SqlDbType.Float).Value = result;
                cmd.Parameters.Add("@login", SqlDbType.NVarChar).Value = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                cmd.Parameters.Add("@hostName", SqlDbType.NVarChar).Value = Environment.MachineName;
                cmd.Parameters.Add("@dateTime", SqlDbType.DateTime).Value = DateTime.Now;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }

        public void AddRecord(string condition, string textError)
        {
            using (SqlCommand cmd = new SqlCommand("INSERT INTO History(Condition,Error,DateTime,Login,HostName) VALUES(@condition,@error,@dateTime,@login,@hostName)", Connection))
            {
                cmd.Parameters.Add("@condition", SqlDbType.NVarChar).Value = condition;
                cmd.Parameters.Add("@error", SqlDbType.NVarChar).Value = textError;
                cmd.Parameters.Add("@login", SqlDbType.NVarChar).Value = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                cmd.Parameters.Add("@hostName", SqlDbType.NVarChar).Value = Environment.MachineName;
                cmd.Parameters.Add("@dateTime", SqlDbType.DateTime).Value = DateTime.Now;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }

        public void AddRecord(Record record)
        { if (record.Result == null)
                {
            using (SqlCommand cmd = new SqlCommand("INSERT INTO History(Condition,Error,DateTime,Login,HostName) VALUES(@condition,@error,@dateTime,@login,@hostName)", Connection))
            {
               
                    cmd.Parameters.Add("@condition", SqlDbType.NVarChar).Value = record.Task;
                    cmd.Parameters.Add("@result", SqlDbType.Float).Value = DBNull.Value;
                    cmd.Parameters.Add("@error", SqlDbType.NVarChar).Value = record.Error;
                    cmd.Parameters.Add("@login", SqlDbType.NVarChar).Value = record.Login;
                    cmd.Parameters.Add("@hostName", SqlDbType.NVarChar).Value = record.HostName;
                    cmd.Parameters.Add("@dateTime", SqlDbType.NVarChar).Value = record.DateTime;
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                }
               
            }
            else
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO History(Condition,Result,DateTime,Login,HostName) VALUES(@condition,@result,@dateTime,@login,@hostName)", Connection))
                {
                    cmd.Parameters.Add("@condition", SqlDbType.NVarChar).Value = record.Task;
                    cmd.Parameters.Add("@result", SqlDbType.NVarChar).Value = record.Result;
                    cmd.Parameters.Add("@login", SqlDbType.NVarChar).Value = record.Login;
                    cmd.Parameters.Add("@hostName", SqlDbType.NVarChar).Value = record.HostName;
                    cmd.Parameters.Add("@dateTime", SqlDbType.NVarChar).Value = record.DateTime;
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public Record GetRecord(int id, CultureInfo culture)
        {
            string condition=null,error=null, login=null, hostName=null, result=null;
            DateTime dateTime=DateTime.Now;

            using (SqlCommand command =
                new SqlCommand(String.Format("Select Id, Condition, Result, Error, DateTime, Login, HostName from [History] where Id={0}", id), Connection))
            {
                command.ExecuteNonQuery();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                         condition = reader["Condition"].ToString();
                         result = reader["Result"].ToString();
                         error = reader["Error"].ToString();
                         dateTime = (DateTime)reader["DateTime"];
                         login = reader["Login"].ToString();
                         hostName = reader["HostName"].ToString();
                    }
                }
            }

            double res;
            double? My_Value = double.TryParse(result, NumberStyles.Any, culture, out res)
                ? (double?) res
                : null;

            return new Record(condition, My_Value, error, dateTime, login, hostName);
        }

        public void updateRecord(Record record, int id)
        {
            if (true)
                using (SqlCommand cmd =
                    new SqlCommand("Update",Connection))
                {
                 
                    cmd.Parameters.Add("@condition", SqlDbType.NVarChar).Value = record.Task;
                    cmd.Parameters.Add("@error", SqlDbType.NVarChar).Value = record.Error;
                    cmd.Parameters.Add("@result", SqlDbType.Float).Value = record.Result;
                    cmd.Parameters.Add("@dateTime", SqlDbType.NVarChar).Value = record.DateTime;
                    cmd.Parameters.Add("@login", SqlDbType.NVarChar).Value = record.Login;
                    cmd.Parameters.Add("@hostName", SqlDbType.NVarChar).Value = record.HostName;
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                }
            else
            {
                using (SqlCommand cmd =
                    new SqlCommand(
                        "UPDATE History SET Condition = @condition, Result = @result, Error = @error, " +
                        "DateTime = @dateTime, Login = @login, HostName = @hostName WHERE id = @id",
                        Connection))
                {
                    cmd.Parameters.Add("@condition", SqlDbType.NVarChar).Value = record.Task;
                    cmd.Parameters.Add("@result", SqlDbType.Float).Value = DBNull.Value;
                    cmd.Parameters.Add("@error", SqlDbType.NVarChar).Value = record.Error;
                    cmd.Parameters.Add("@dateTime", SqlDbType.NVarChar).Value = record.DateTime;
                    cmd.Parameters.Add("@login", SqlDbType.NVarChar).Value = record.Login;
                    cmd.Parameters.Add("@hostName", SqlDbType.NVarChar).Value = record.HostName;
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteRecord(int id)
        {
            using (SqlCommand cmd = new SqlCommand("DELETE FROM History WHERE Id = @id", Connection))
            {
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }
    }
}