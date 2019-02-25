using System.ComponentModel;

namespace HistoryRepository
{
    public class Record
    {
        public string Task { get; }
        public string Error { get; }
        public double? Result { get; }
        public string DateTime { get; }
        public string Login { get; }
        public string HostName { get; }

        public Record(string task, double? result, string error, string dateTime, string login, string hostName)
        {
            Task = task;
            Result = result;
            Error = error;
            DateTime = dateTime;
            Login = login;
            HostName = hostName;
        }

    }
}