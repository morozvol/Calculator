using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace HistoryRepository
{
    public class Record
    {
        public string Task { get; private set; }
        public string Error { get; private set; }
        public double? Result { get; private set; }

        public Record(string task, double? result, string error)
        {
            Task = task;
            Result = result;
            Error = error;
        }

    }
}