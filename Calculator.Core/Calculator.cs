using System;
using System.Collections.Generic;
using System.Globalization;
using Calculator.Core.Operations;
namespace Calculator.Core
{
    public class Calculator
    {
        public CultureInfo Culture { get; }
        public string Condition { get; private set; }
        public string Task { get;}
        public bool IsError { get; set; }
     
        
        public Calculator(string condition,CultureInfo culture,string task)
        {
            Condition = condition;
            IsError = false;
            Culture = culture;
            Task = task;
        }

        private bool IsFindErrorInTask(ref Tracing tracing)
        {
            if (Condition.Length < 1)
            {
                OnErrorEvent("введена пустая строка",ref tracing);
                return true;
            }

            if (Condition.Split('(', ')').Length % 2 == 0)
            {
                OnErrorEvent("ошибка скобок",ref tracing);
                return true;
            }

            return false;
        }

        private void ReplaceBinaryOperator()
        {
            for (int i = 0; i < Condition.Length; i++)
            {
                if (Condition[i] == '-')
                {
                    if (i != 0 && Condition[i - 1] != '(')
                        Condition = Condition.Remove(i, 1).Insert(i, "~");
                }
            }
        }
      

        private bool IsSimple()
        {
            double buffer;
              return  double.TryParse(Condition, NumberStyles.Any, Culture, out buffer);
        }

        private void OnErrorEvent(string str,ref Tracing tracing)
        {
            IsError = true;
            tracing.Error = str;
            // throw new ErrorException(str);


        }

        public Tracing CalculateExpression()
        {   
            Tracing tracing = new Tracing();
            if (IsFindErrorInTask(ref tracing)) return tracing;
            ReplaceBinaryOperator();
            
              var result =  Simplify( ref tracing);
              tracing.Result = result == "Error" ? null : (double?)Double.Parse(result);
              
              return tracing;
        }

        private string Simplify(ref Tracing tracing)
        {
            while (true)
            {
                if (IsError || Condition == "Error") return "Error";
                Bracket bracket = FindTheActionIBrackets(ref tracing);
                if (bracket.LengthBracket == 0) break;
                {
                    var c2 = Condition.Substring(bracket.OpenBracketIndex, bracket.LengthBracket);
                    var calculator = new Calculator(c2.Substring(1, c2.Length - 2),Culture,Task);
                    Condition = Condition.Replace(c2, calculator.Simplify(ref tracing));
                }
            }

            while (!IsSimple())
            {
                var operations = SplitIntoOperation(ref tracing);
                if (operations.Count == 0)
                {
                    OnErrorEvent("Выражение введено неверно!",ref tracing);
                    if (IsError || Condition == "Error") return "Error";
                }

                var main = Operation.ChooseMainOperation(operations);
               
                tracing.list.Add(main);
                main.Calculate();
                ChangeCondition(main);
            }

            return Condition;
        }

        private void ChangeCondition(Operation op)
        {
        
            Condition = Condition.Replace(String.Format("{0}{1}{2}", op.Number1, op.Options=="-" ? "~" : op.Options, op.Number2, Culture), op.Result.ToString(Culture));
        }

        private Bracket FindTheActionIBrackets(ref Tracing tracing)
        {
            if (!Condition.Contains("(") || !Condition.Contains(")"))
                return new Bracket(0, 0);

            byte openBracket = 128, lengthBracket;
            for (byte i = 0; i < Condition.Length; i++)
            {
                if (Condition[i] == '(')
                    openBracket = i;
                if (Condition[i] == ')')
                {
                    if (openBracket > i)
                    {
                        OnErrorEvent("ошибка скобок", ref tracing);
                    }

                    lengthBracket = (byte) (i - openBracket + 1);
                    return new Bracket(openBracket, lengthBracket);
                }
            }

            return new Bracket(0, 0);
        }

        private List<Operation> SplitIntoOperation(ref Tracing tracing)
        {
             var numbers = Condition.Split(String.Join("", Operation.Creators.Keys).ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            var symbols = Condition.Split("0123456789.,-".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            
            int i = 0;
            List<Operation> Operations = new List<Operation>();
            for (int j = 0; j < numbers.Length - 1; j++)
            {
                try
                {
                    var number1 = double.Parse(numbers[j], Culture);
                    var number2 = double.Parse(numbers[j + 1], Culture);
                    Operations.Add(Creator.Create(number1, number2, symbols[i]));
                    i++;
                }
                catch (FormatException)
                {
                    OnErrorEvent("Выражение введено неверно!",ref tracing);
                }
            }

            return Operations;
        }



    }
}