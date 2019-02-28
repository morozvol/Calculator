using System;
using System.ComponentModel;

namespace Calculator.HistoryRepository
{
    public class Record
    {
        public string Task { get; }
        public string Error { get; }
        public double? Result { get; }
        public DateTime DateTime { get; }
        public string Login { get; }
        public string HostName { get; }

        public Record(string task, double? result, string error, DateTime dateTime, string login, string hostName)
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