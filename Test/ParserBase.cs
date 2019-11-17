using System;

namespace Calculadorastack {
    public class ParserBase {
        private int dbgCallLevel;

        private string operacionCruda;

        private int indiceOperacion;

        public ParserBase(string operacionCruda) {
            this.operacionCruda = operacionCruda;
            this.indiceOperacion = 0;
            this.dbgCallLevel = 0;
        }

        protected int getInt() {
            int a = (int) Actual();
            if (a < 0x30 || a > 0x39) {
                throw new SintaxisError();
            }
            printDbgLevel();
            Console.WriteLine("ST: " + (a - 0x30));
            return a - 0x30;
        }

        protected char Actual() {
            if (FinDeEntrada())
                //throw new FinDeOperacion();
                return ' ';
            printDbgLevel();
            Console.WriteLine("Actual: " + this.operacionCruda[indiceOperacion]);
            return this.operacionCruda[indiceOperacion];
        }

        protected void Avanzar() {
            printDbgLevel();
            Console.WriteLine("Actual: " + this.operacionCruda[indiceOperacion]);
            if (FinDeEntrada())
                throw new FinDeOperacion();
            this.indiceOperacion++;
        }

        protected bool FinDeEntrada() {
            return this.indiceOperacion >= this.operacionCruda.Length;
        }

        protected void printDbgBegin(string funcName) {
            this.dbgCallLevel++;
            printDbgLevel();
            Console.WriteLine("begin " + funcName);
        }

        protected void printDbgEnd(string funcName) {
            printDbgLevel();
            Console.WriteLine("end " + funcName);
            this.dbgCallLevel--;
        }

        private void printDbgLevel() {
            Console.Write(this.dbgCallLevel);
            for (int i = 0; i < this.dbgCallLevel * 4; i++)
                Console.Write(" ");
        }

        protected void printDbg(object msg) {
            printDbgLevel();
            Console.WriteLine("" + msg);
        }
    }
}