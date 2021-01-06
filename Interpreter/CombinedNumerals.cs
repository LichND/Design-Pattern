


namespace RomanNumerals {

    public class I_CombinedNumeral : CombinedNumeral {
        public I_CombinedNumeral(TerminalNumeral number) : base(new I_Numeral(), number) {
            if (!this.IsCombinedAllow()) {
                throw new System.Exception("Invalid numeral");
            }
        }

        public override int Interpret()
        {
            var first = this.firstNum.Interpret();
            var second = this.secondNum.Interpret();
            return first < second ? second - first : first + second; 
        }

        protected bool IsCombinedAllow() {
            switch (this.secondNum.Type) {
                case RomanNumericTypes.V:
                case RomanNumericTypes.X:
                    return true;
            }
            return false;
        }
    }

    public class X_CombinedNumeral : CombinedNumeral {
        public X_CombinedNumeral(TerminalNumeral number) : base(new X_Numeral(), number) {
            if (!this.IsCombinedAllow()) {
                throw new System.Exception("Invalid numeral");
            }
        }

        public override int Interpret()
        {
            var first = this.firstNum.Interpret();
            var second = this.secondNum.Interpret();
            return first < second ? second - first : first + second; 
        }

        protected bool IsCombinedAllow() {
            switch (this.secondNum.Type) {
                case RomanNumericTypes.L:
                case RomanNumericTypes.C:
                    return true;
            }
            return false;
        }
    }

    public class C_CombinedNumeral : CombinedNumeral {
        public C_CombinedNumeral(TerminalNumeral number) : base(new C_Numeral(), number) {
            if (!this.IsCombinedAllow()) {
                throw new System.Exception("Invalid numeral");
            }
        }

        public override int Interpret()
        {
            var first = this.firstNum.Interpret();
            var second = this.secondNum.Interpret();
            return first < second ? second - first : first + second; 
        }

        protected bool IsCombinedAllow() {
            switch (this.secondNum.Type) {
                case RomanNumericTypes.D:
                case RomanNumericTypes.M:
                    return true;
            }
            return false;
        }
    }
}