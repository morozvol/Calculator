namespace Calculator.Core.Operations.SpecificOperation
{
    class Mul : Operation
    {

        public Mul(double num1, double num2)
        {
            Number1 = num1;
            Number2 = num2;
            Options = "*";
            _preorety = 1;
        }


        public override void Calculate()
        {
            Result = Number1 * Number2;
        }
    }
}
