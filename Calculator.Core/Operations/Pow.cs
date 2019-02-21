using System;


namespace Calculator.Core
{
    internal class Pow : Operation
    {
        public const string Symbol = "^";

        public Pow(double num1, double num2) : base(num1, num2)
        {
            Options = Symbol;
        }


        public override void Calculate()
        {
            Result = (Math.Pow(Number1, Number2));
        }

        public override int GetPriority()
        {
            return 2;
        }
    }
}