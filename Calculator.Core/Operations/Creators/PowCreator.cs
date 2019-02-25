using Calculator.Core.Operations.SpecificOperation;

namespace Calculator.Core.Operations.Creators
{
    class PowCreator : Creator
    {
        public override Operation FactoryMethod(double num1, double num2)
        {
            return new Pow(num1, num2);
        }
    }
}
