using Calculator.Core.Operations.SpecificOperation;

namespace Calculator.Core.Operations.Creators
{
    class MulCreator : Creator
    {
        public override Operation FactoryMethod(double num1, double num2)
        {
            return new Mul(num1, num2);
        }
    }
}
