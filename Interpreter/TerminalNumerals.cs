


namespace RomanNumerals {

    public class I_Numeral : TerminalNumeral {

        public I_Numeral(): base(RomanNumericTypes.I) {
        }
        
        public override int Interpret() {
            return 1;
        }
    }

    public class V_Numeral : TerminalNumeral {
        
        public V_Numeral(): base(RomanNumericTypes.V) {
        }

        public override int Interpret() {
            return 5;
        }
    }

    public class X_Numeral : TerminalNumeral {
        
        public X_Numeral(): base(RomanNumericTypes.X) {
        }

        public override int Interpret() {
            return 10;
        }
    }

    public class L_Numeral : TerminalNumeral {
        
        public L_Numeral(): base(RomanNumericTypes.L) {
        }

        public override int Interpret() {
            return 50;
        }
    }

    public class C_Numeral : TerminalNumeral {
        
        public C_Numeral(): base(RomanNumericTypes.C) {
        }

        public override int Interpret() {
            return 100;
        }
    }

    public class D_Numeral : TerminalNumeral {
        
        public D_Numeral(): base(RomanNumericTypes.D) {
        }

        public override int Interpret() {
            return 500;
        }
    }

    public class M_Numeral : TerminalNumeral {
        
        public M_Numeral(): base(RomanNumericTypes.M) {
        }

        public override int Interpret() {
            return 1000;
        }
    }
}