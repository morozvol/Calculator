using System.Collections.Generic;
using Calculator.Core.Operations;

namespace Calculator.Core
{
    public class Tracing
    {
        public List<Operation> list { get;} = new List<Operation>();
        public string Error { get; set; } = null;
        public double? Result { get; set; } = null;
    }
}
