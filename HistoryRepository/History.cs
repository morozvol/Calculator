using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using HistoryRepository;


namespace History
{
    public class History
    {
        public SqlConnection Connection { get; private set; }

        public History()
        {
            Connection = new SqlConnection(@"Data Source=HYPER2\MISC;Initial Catalog=CalculatorHistory;User ID=SA1;Password=111");

        }

        public void AddRecord(string condition, double result)
        {
            string sql = "INSERT INTO History(Condition,Result) VALUES(@condition,@result)";
            SqlCommand cmd = new SqlCommand(sql, Connection);
            cmd.Parameters.Add("@condition", SqlDbType.Text).Value = condition;
            cmd.Parameters.Add("@result", SqlDbType.Float).Value = result;
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
        }

        public void AddRecord(string condition, string textError)
        {
            string sql = "INSERT INTO History(Condition,Error) VALUES(@condition,@error)";
            SqlCommand cmd = new SqlCommand(sql, Connection);
            cmd.Parameters.Add("@condition", SqlDbType.Text).Value = condition;
            cmd.Parameters.Add("@error", SqlDbType.NVarChar).Value = textError;
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
        }

        public Record GetLastRecord()
        {
            Open();

            SqlCommand cmd = this.Connection.CreateCommand();
            cmd.CommandText = @"select * from History
                              where id = (select max(id) from History)";
            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        var task = reader.IsDBNull(1) ? null : reader.GetString(1);
                        double? result = reader.IsDBNull(2) ? null : (double?)reader.GetDouble(2);
                        string error = reader.IsDBNull(3) ? null : reader.GetString(3);
                        Close();
                        return new Record(task, result, error);
                    }
                }
            }
            Close();
            return new Record(null, null, "ошибка чтения с базы данных");
        }

        public void Close()
        {
            Connection.Close();
        }

        public bool Open()
        {
            try
            {
                Connection.Open();
            }
            catch (SqlException)
            {
                return false;
            }

            return true;
        }
    }
}