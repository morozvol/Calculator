using System;
using System.Data;
using System.Data.SqlClient;


namespace HistoryRepository
{
    public class History
    {
        public SqlConnection Connection { get;  }

        public History()
        {
            Connection = new SqlConnection(Properties.Resource.ConnectingString);

        }


        public void AddRecord(string condition, double result)
        {
            using (SqlCommand cmd = new SqlCommand(Properties.Resource.AddrRsult, Connection))
            {
                cmd.Parameters.Add("@condition", SqlDbType.Text).Value = condition;
                cmd.Parameters.Add("@result", SqlDbType.Float).Value = result;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }

        public void AddRecord(string condition, string textError)
        {
            using (SqlCommand cmd = new SqlCommand(Properties.Resource.AddError, Connection))
            {
                cmd.Parameters.Add("@condition", SqlDbType.Text).Value = condition;
                cmd.Parameters.Add("@error", SqlDbType.NVarChar).Value = textError;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }
        public  Record GetRecord(int id)
        {
            string[] arr = new String[7];
            using (SqlCommand command =
                new SqlCommand(String.Format("Select * from [History] where Id={0}", id), Connection))
            {Connection.Open();
                // command.Parameters.AddWithValue("@zip", "india");
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
                ? (double?)result
                : null;
            
            return new Record(arr[1], My_Value, arr[3], arr[4], arr[5], arr[6]);
        }

    }
}