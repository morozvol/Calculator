namespace Calculator.Core
{
    internal class Bracket
    {
        public readonly byte OpenBracketIndex;
        public readonly byte LengthBracket;

        public Bracket(byte open, byte length)
        {
            OpenBracketIndex = open;
            LengthBracket = length;
        }
    }
    }