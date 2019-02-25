namespace Calculator.Core.Operations
{
    public abstract class Creator
    {
        public static Operation Create(double num1,double num2,string symbol)
        {
            return Operation.Creators[symbol].FactoryMethod(num1, num2);
        }

        public abstract Operation FactoryMethod(double num1, double num2);
    }
}
