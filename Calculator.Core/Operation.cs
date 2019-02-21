using System.Collections.Generic;
using System.Dynamic;

namespace Calculator.Core
{
    internal class Operation
    {
        public const string Symbols = Sum.Symbol + Subtract.Symbol +
                                      Multiply.Symbol + Div.Symbol + Pow.Symbol;
        public string Options { get; set; }
        public double Result { get; protected set; }
        public  double Number1 { get; }
        public  double Number2 { get; }

        public Operation(double num1, double num2)
        {
            Number1 = num1;
            Number2 = num2;
        }


        public static Operation ChooseTheMain(List<Operation> operations)
        {
            int maxPriority=0;
            foreach (var op in operations)
            {
                if (op.GetPriority() > maxPriority) maxPriority = op.GetPriority();
            }
            foreach (var op in operations)
            {
                if (op.GetPriority() == maxPriority) return op;
            }
            return new Sum(1,2);
        }

        public virtual void Calculate()
        {
        }

        public virtual int GetPriority()
        {
            return 0;
        }

        public static Operation ChooseOperation(double num1, double num2, string symbol)
        {
            switch (symbol)
            {
                case Subtract.Symbol:
                    return new Subtract(num1, num2);
                case Sum.Symbol:
                    return new Sum(num1, num2);

                case Multiply.Symbol:
                    return new Multiply(num1, num2);

                case Div.Symbol:
                    return new Div(num1, num2);

                case Pow.Symbol:
                    return new Pow(num1, num2);

                default:
                   // OnErrorEvent("Выражение введено неверно!");
                    return new Pow(num1, num2);
            }
        }
    }
}