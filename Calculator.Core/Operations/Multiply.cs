using System;

namespace Calculator.Core
{
    internal class Multiply : Operation
    {
        public const string Symbol = "*";

        public Multiply(double num1, double num2) : base(num1, num2)
        {
            Options = Symbol;
        }


        public override void Calculate()
        {
            Result = (Number1 * Number2);
        }

        public override int GetPriority()
        {
            return 1;
        }
    }
}