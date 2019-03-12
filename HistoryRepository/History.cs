using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using Calculator.Core;
using Calculator.Core.Operations;


namespace Calculator.HistoryRepository
{
    public class History
    {
        public SqlConnection Connection { get; }

        public History(string connectionString)
        {
            Connection = new SqlConnection(connectionString);
            Connection.Open();
        }


        public void AddRecord(string condition, Tracing tracing)
        {
            using (SqlCommand cmd = new SqlCommand("TracingAdd", Connection))
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("operand_1", typeof(double));
                dt.Columns.Add("operand_2", typeof(double));
                dt.Columns.Add("operations", typeof(string));
                dt.Columns.Add("result", typeof(double));
                dt.Columns.Add("error", typeof(string));
                foreach (var operetion in tracing.list)
                {
                    DataRow ravi = dt.NewRow();
                    ravi["operand_1"] = operetion.Number1;
                    ravi["operand_2"] = operetion.Number2;
                    ravi["operations"] = operetion.Options;
                    ravi["result"] = operetion.Result==null? DBNull.Value:(object)operetion.Result;
                    ravi["error"] = operetion.Error;
                    dt.Rows.Add(ravi); 
                }

                SqlParameter param = new SqlParameter("@tracing", SqlDbType.Structured)
                {
                    TypeName = "dbo.TracingType",
                    Value = dt
                };
                cmd.Parameters.Add(param);
                cmd.Parameters.Add("@condition", SqlDbType.NVarChar).Value = condition;
                cmd.Parameters.Add("@result", SqlDbType.Float).Value =
                    tracing.Result == null ? DBNull.Value : (object) tracing.Result;
                cmd.Parameters.Add("@error", SqlDbType.NVarChar).Value =
                    tracing.Error == null ? DBNull.Value : (object) tracing.Error;
                cmd.Parameters.Add("@login", SqlDbType.NVarChar).Value =
                    System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                cmd.Parameters.Add("@host_name", SqlDbType.NVarChar).Value = Environment.MachineName;
                cmd.Parameters.Add("@date_time", SqlDbType.DateTime).Value = DateTime.Now;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
            }
        }


        public void AddRecord(Record record)
        {
            //if (record != null)
            //    using (SqlCommand cmd = new SqlCommand("CreateNewRecord", Connection))
            //    {
            //        cmd.Parameters.Add("@condition", SqlDbType.NVarChar).Value = record.Task;
            //        cmd.Parameters.Add("@result", SqlDbType.Float).Value =
            //            record.Result == null ? DBNull.Value : (object) record.Result;
            //        cmd.Parameters.Add("@error", SqlDbType.NVarChar).Value = record.Error;
            //        cmd.Parameters.Add("@login", SqlDbType.NVarChar).Value = record.Login;
            //        cmd.Parameters.Add("@host_name", SqlDbType.NVarChar).Value = record.HostName;
            //        cmd.Parameters.Add("@date_time", SqlDbType.DateTime).Value = record.DateTime;
            //        cmd.CommandType = CommandType.StoredProcedure;
            //        cmd.ExecuteNonQuery();
            //    }
        }


        public Record GetRecord(int id, CultureInfo culture)
        {
            string condition = null, error = null, login = null, hostName = null, result = null;
            DateTime dateTime = DateTime.Now;

            using (SqlCommand command = new SqlCommand("CalcLogRecordGet", Connection))
            {
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        condition = reader["condition"].ToString();
                        result = reader["result"].ToString();
                        error = reader["error"].ToString();
                        dateTime = (DateTime) reader["time_calculation"];
                        login = reader["login"].ToString();
                        hostName = reader["host_name"].ToString();
                    }
                }
            }

            double res;
            double? My_Value = double.TryParse(result, NumberStyles.Any, culture, out res)
                ? (double?) res
                : null;

            return new Record(condition, My_Value, error, dateTime, login, hostName);
        }

        public global::HistoryRepository.Operation GetTracing(int id)
        {
            string option = null;
            double result, num1, num2;


            using (SqlCommand command = new SqlCommand("CalcLogRecordGet", Connection))
            {
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {

                        result = Double.Parse(reader["result"].ToString());
                        num1 = Double.Parse(reader["operator_1"].ToString());
                        num2 = Double.Parse(reader["operator_2"].ToString());
                        option = reader["error"].ToString();
                        return new global::HistoryRepository.Operation(option, result, num1, num2);
                    }
                }
            }
            return new global::HistoryRepository.Operation(null,0,0,0);
        }

    public void UpdateRecord(Record record, int id)
        {
            if (record != null)
            {
                using (SqlCommand cmd = new SqlCommand("CalcLogRecordUpdate", Connection))
                {
                    cmd.Parameters.Add("@condition", SqlDbType.NVarChar).Value = record.Task;
                    cmd.Parameters.Add("@error", SqlDbType.NVarChar).Value = record.Error;
                    cmd.Parameters.Add("@result", SqlDbType.Float).Value =
                        record.Result == null ? DBNull.Value : (object) record.Result;
                    cmd.Parameters.Add("@date_time", SqlDbType.DateTime).Value = record.DateTime;
                    cmd.Parameters.Add("@login", SqlDbType.NVarChar).Value = record.Login;
                    cmd.Parameters.Add("@host_name", SqlDbType.NVarChar).Value = record.HostName;
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteRecord(int id)
        {
            using (SqlCommand cmd = new SqlCommand("CalcLogRecordDelete", Connection))
            {
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
            }
        }
    }
}