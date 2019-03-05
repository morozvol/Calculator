using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using Calculator.Core;


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
            using (SqlCommand CreateTempTable = new SqlCommand("CreateTempTracing", Connection))
            {
                CreateTempTable.CommandType = CommandType.StoredProcedure;
                CreateTempTable.ExecuteScalar();


                using (SqlCommand AddTracimgInTempTaeble = new SqlCommand("AddTracing", Connection))
                {
                    foreach (var operation in tracing.list)
                    {
                        // operand_1, operand_2, operations, result, error
                        AddTracimgInTempTaeble.Parameters.Add("@operand_1", SqlDbType.Float).Value = operation.Number1;
                        AddTracimgInTempTaeble.Parameters.Add("@operand_2", SqlDbType.Float).Value = operation.Number2;
                        AddTracimgInTempTaeble.Parameters.Add("@result", SqlDbType.Float).Value = operation.Result;
                        AddTracimgInTempTaeble.Parameters.Add("@operation", SqlDbType.Char).Value = operation.Options;
                        AddTracimgInTempTaeble.Parameters.Add("@error", SqlDbType.NVarChar).Value = operation.Error;

                        AddTracimgInTempTaeble.CommandType = CommandType.StoredProcedure;
                        AddTracimgInTempTaeble.ExecuteScalar();
                    }
                }

                using (SqlCommand cmd = new SqlCommand("AddRecord", Connection))
                    {
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
                    }
                
            }
        }

        public void AddRecord(Record record)
        {
            if (record != null)
                using (SqlCommand cmd = new SqlCommand("AddRecord", Connection))
                {
                    cmd.Parameters.Add("@condition", SqlDbType.NVarChar).Value = record.Task;
                    cmd.Parameters.Add("@result", SqlDbType.Float).Value =
                        record.Result == null ? DBNull.Value : (object) record.Result;
                    cmd.Parameters.Add("@error", SqlDbType.NVarChar).Value = record.Error;
                    cmd.Parameters.Add("@login", SqlDbType.NVarChar).Value = record.Login;
                    cmd.Parameters.Add("@host_name", SqlDbType.NVarChar).Value = record.HostName;
                    cmd.Parameters.Add("@date_time", SqlDbType.DateTime).Value = record.DateTime;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                }
        }


        public Record GetRecord(int id, CultureInfo culture)
        {
            string condition = null, error = null, login = null, hostName = null, result = null;
            DateTime dateTime = DateTime.Now;

            using (SqlCommand command = new SqlCommand("GetRecord", Connection))
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

        public void UpdateRecord(Record record, int id)
        {
            if (record != null)
            {
                using (SqlCommand cmd = new SqlCommand("Update", Connection))
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
            using (SqlCommand cmd = new SqlCommand("Delete", Connection))
            {
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
            }
        }
    }
}