using System;

namespace Calculator.Core.Operations.SpecificOperation
{
    class Pow : Operation
    {
        public Pow(double num1, double num2)
        {
            Number1 = num1;
            Number2 = num2;
            Options = "+";
            _preorety = 3;
        }


        public override void Calculate()
        {
            Result =Math.Pow(Number1, Number2);
        }
    }
}
