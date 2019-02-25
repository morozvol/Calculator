using System.Globalization;
using HistoryRepository;

namespace Calculator.Console
{
    class Program
    {
        private static void Main()
        {

        var task = System.Console.ReadLine().Replace(" ", string.Empty);
            History history = new History();

            CultureInfo culture = CultureInfo.GetCultureInfo("ru-RU");

            Core.Calculator calculator = new Core.Calculator(task, culture, task);
            var result = calculator.CalculateExpression();

            var lastRecord = history.GetLastRecord();
            System.Console.Clear();
            System.Console.WriteLine("{0}={1}{2}", lastRecord.Task,
                lastRecord.Result,
                lastRecord.Error);

            System.Console.ReadKey();
        }
    }
}