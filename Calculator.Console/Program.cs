using System;
using System.Globalization;


namespace Calculator
{
    class Program
    {
        private static void Main()
        {

        var task = Console.ReadLine().Replace(" ", string.Empty);
            History.History history = new History.History();

            CultureInfo culture = CultureInfo.GetCultureInfo("ru-RU");

            Core.Calculator calculator = new Core.Calculator(task, culture, task);
            var result = calculator.CalculateExpression();

            var lastRecord = history.GetLastRecord();
            Console.Clear();
            Console.WriteLine("{0}={1}{2}", lastRecord.Task,
                lastRecord.Result,
                lastRecord.Error);

            Console.ReadKey();
        }
    }
}