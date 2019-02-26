using System;
using System.Data;
using System.Data.SqlClient;


namespace HistoryRepository
{
    public class History
    {
        public SqlConnection Connection { get; }

        public History()
        {
            Connection = new SqlConnection(Properties.Resource.ConnectingString);
            Connection.Open();
        }


        public void AddRecord(string condition, double result)
        {
            using (SqlCommand cmd = new SqlCommand(Properties.Resource.AddrRsult, Connection))
            {
                cmd.Parameters.Add("@condition", SqlDbType.NVarChar).Value = condition;
                cmd.Parameters.Add("@result", SqlDbType.Float).Value = result;
                cmd.Parameters.Add("@login", SqlDbType.NVarChar).Value = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                cmd.Parameters.Add("@hostName", SqlDbType.NVarChar).Value = Environment.MachineName;
                cmd.Parameters.Add("@dateTime", SqlDbType.NVarChar).Value = DateTime.Now.ToString("dd.MM.yyyyг. hh: mm ");
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }

        public void AddRecord(string condition, string textError)
        {
            using (SqlCommand cmd = new SqlCommand(Properties.Resource.AddError, Connection))
            {
                cmd.Parameters.Add("@condition", SqlDbType.NVarChar).Value = condition;
                cmd.Parameters.Add("@error", SqlDbType.NVarChar).Value = textError;
                cmd.Parameters.Add("@login", SqlDbType.NVarChar).Value = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                cmd.Parameters.Add("@hostName", SqlDbType.NVarChar).Value = Environment.MachineName;
                cmd.Parameters.Add("@dateTime", SqlDbType.NVarChar).Value = DateTime.Now.ToString("dd.MM.yyyyг. hh: mm ");
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }

        public Record GetRecord(int id)
        {
            string[] arr = new String[7];
            using (SqlCommand command =
                new SqlCommand(String.Format("Select * from [History] where Id={0}", id), Connection))
            {
                command.ExecuteNonQuery();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        arr[0] = reader["Id"].ToString();
                        arr[1] = reader["Condition"].ToString();
                        arr[2] = reader["Result"].ToString();
                        arr[3] = reader["Error"].ToString();
                        arr[4] = reader["DateTime"].ToString();
                        arr[5] = reader["Login"].ToString();
                        arr[6] = reader["HostName"].ToString();
                    }
                }
            }

            double result;
            double? My_Value = double.TryParse(arr[2], out result)
                ? (double?) result
                : null;

            return new Record(arr[1], My_Value, arr[3], arr[4], arr[5], arr[6]);
        }

        public void updateRecord(Record record, int id)
        {
            if (record.Result != null)
                using (SqlCommand cmd =
                    new SqlCommand(
                        "UPDATE History SET Condition = @condition," +
                        " Result = @result, Error = @error, DateTime = @dateTime, " +
                        "Login = @login, HostName = @hostName WHERE id = @id",
                        Connection))
                {
                    cmd.Parameters.Add("@condition", SqlDbType.NVarChar).Value = record.Task;
                    cmd.Parameters.Add("@error", SqlDbType.NVarChar).Value = record.Error;
                    cmd.Parameters.Add("@result", SqlDbType.Float).Value = record.Result;
                    cmd.Parameters.Add("@dateTime", SqlDbType.NVarChar).Value = record.DateTime;
                    cmd.Parameters.Add("@login", SqlDbType.NVarChar).Value = record.Login;
                    cmd.Parameters.Add("@hostName", SqlDbType.NVarChar).Value = record.HostName;
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                }
            else
            {
                using (SqlCommand cmd =
                    new SqlCommand(
                        "UPDATE History SET Condition = @condition, Error = @error, " +
                        "DateTime = @dateTime, Login = @login, HostName = @hostName WHERE id = @id",
                        Connection))
                {
                    cmd.Parameters.Add("@condition", SqlDbType.NVarChar).Value = record.Task;
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