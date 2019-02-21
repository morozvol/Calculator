using System;

namespace Calculator.Core
{
    internal class Sum : Operation
    {
        public const string Symbol = "+";

        public Sum(double num1, double num2) : base(num1, num2)
        {
            Options = Symbol;
        }


        public override void Calculate()
        {
            Result = (Number1 + Number2);
        }

        public override int GetPriority()
        {
            return 0;
        }
    }
}