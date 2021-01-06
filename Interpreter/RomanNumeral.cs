

namespace RomanNumerals
{
    public interface IRomanNumeral {
        int Interpret();
    }

    public abstract class TerminalNumeral : IRomanNumeral
    {
        protected RomanNumericTypes type;

        public TerminalNumeral(RomanNumericTypes type) {
            this.type = type;
        }

        public RomanNumericTypes Type {
            get => type;
        }
        public abstract int Interpret();
    }

    public abstract class CombinedNumeral : IRomanNumeral {
        
        protected TerminalNumeral firstNum;
        protected TerminalNumeral secondNum;
        public CombinedNumeral(TerminalNumeral firstNum, TerminalNumeral secondNum) {
            this.firstNum = firstNum;
            this.secondNum = secondNum;
        }
        public abstract int Interpret();
    }
}