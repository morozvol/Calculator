namespace HistoryRepository
{
   public class Operation
    {
        public string Options { get; protected set; }
        public double Result { get; protected set; }
        public double Number1 { get; protected set; }
        public double Number2 { get; protected set; }

        public Operation(string options, double result, double number1, double number2)
        {
            Options = options;
            Result = result;
            Number1 = number1;
            Number2 = number2;
        }
    }
}
