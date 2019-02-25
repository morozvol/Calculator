using System.Collections.Generic;
using Calculator.Core.Operations.Creators;
using Calculator.Core.Operations.SpecificOperation;
using DivCreator = Calculator.Core.Operations.Creators.DivCreator;

namespace Calculator.Core.Operations
{
    public abstract class Operation
    {
        public string Options { get; protected set; }
        public double Result  { get; protected set; }
        public double Number1 { get; protected set; }
        public double Number2 { get; protected set; }
        protected int _preorety;

       public  static readonly Dictionary<string, Creator> Creators = new Dictionary<string, Creator>()
       {
           {"+", new SumCreator()},
           {"~", new SumCreator()},
           {"*", new MulCreator()},
           {"/", new DivCreator()},
           {"^", new PowCreator()},
       };


        public static Operation ChooseMainOperation(List<Operation> operations)
        {
            int maxPriority = 0;
            foreach (var op in operations)
            {
                if (op._preorety > maxPriority) maxPriority = op._preorety;
            }
            foreach (var op in operations)
            {
                if (op._preorety == maxPriority) return op;
            }
            return new Sum(1, 2);
        }

        public abstract void Calculate();

    }
}