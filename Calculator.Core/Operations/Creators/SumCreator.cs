using Calculator.Core.Operations;
using Calculator.Core.Operations.SpecificOperation;

class SumCreator : Creator
{
    public override Operation FactoryMethod(double num1, double num2)
    {
        return new Sum(num1, num2);
    }
}

