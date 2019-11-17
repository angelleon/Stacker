using System;

namespace Calculadorastack {
    public class Parser : ParserBase {

        /*tecnologias retos;
        func terminadas; 
        func noterminadas;*/

        public Parser(string operacionCruda) : base(operacionCruda) {}

        public float Operacion() {
            printDbgBegin("Operacion");
            //throw new SintaxisError();
            if (Char.IsDigit(Actual())) {
                float resultado = TerminoSuma();
                printDbgEnd("Operacion");
                return resultado;
            }
            throw new SintaxisError();
        }

        public float TerminoSuma() {
            printDbgBegin("TerminoSuma");
            float a = FactiorMul();
            if (FinDeEntrada()) {
                printDbgEnd("TerminoSuma");
                return a;
            }
            char operador = Actual();
            float b = TerminoEpsilon();
            if (operador == '+') {
                printDbg("Sumando " + a + " + " + b);
                printDbgEnd("TerminoSuma");
                return a + b;
            }
            if (operador == '-') {
                printDbg("Restando " + a + " - " + b);
                printDbgEnd("TerminoSuma");
                return a - b;
            }
            throw new SintaxisError();
        }

        public float TerminoEpsilon() {
            printDbgBegin("TerminoEpsilon");
            Avanzar();
            float a = Operacion();
            printDbgEnd("TerminoEpsilon");
            return a;
        }

        public float FactiorMul() {
            printDbgBegin("FactorMul");
            float a = getInt();
            Avanzar();
            if (FinDeEntrada()) {
                printDbgEnd("FactorMul");
                return a;
            }
            char operador = Actual();
            printDbg("operador factor " + operador);
            //Avanzar();
            float b = FactorEpsilon();
            if (operador == '*') {
                printDbg("Miltiplicando " + a + " * " + b);
                printDbgEnd("FactorMul");
                return a * b;
            }
            if (operador == '/') {
                printDbg("Dividiendo " + a + " / " + b);
                printDbgEnd("FactorMul");
                return a / b;
            }
            if (operador == '%') {
                printDbg("Resto " + a + " % " + b);
                printDbgEnd("FactorMul");
                return a % b;
            }
            //throw new SintaxisError();
            return 0f;
        }

        public float FactorEpsilon() {
            printDbgBegin("FactorEpsilon");
            Avanzar();
            // float a = Operacion();
            float a = FactiorMul();
            printDbgEnd("FactorEpsilon");
            return a;
        }
    }
}