using Calculator.Core.Operations.SpecificOperation;

namespace Calculator.Core.Operations.Creators
{
    class SubCreator : Creator
    {
        public override Operation FactoryMethod(double num1, double num2)
        {
            return new Sub(num1, num2);
        }
    }
}
