using Calculator.Core.Operations.SpecificOperation;

namespace Calculator.Core.Operations.Creators
{
    class DivCreator : Creator
    {
        public override Operation FactoryMethod(double num1, double num2)
        {
            return new Div(num1, num2);
        }
    }
}
