using System;

namespace Calculadorastack {
    public class PosfijoParser : ParserBase {
        private float[] stack;
        private int stackTop;

        //Array procedimiento = new Array[];

        public PosfijoParser(string operacionCruda) : base(operacionCruda) {
            this.stackTop = 0;
            this.stack = new float[operacionCruda.Length];
            printDbg("operacionCruda " + operacionCruda);
        }

        private void push(float val) {
            printDbgBegin("push");
            Console.WriteLine("pushing into stack: " + val);
            this.stack[this.stackTop] = val;
            this.stackTop++;
        }

        private float pop() {
            this.stackTop--;
            if (this.stackTop < 0) {
                throw new ArgumentosInsuficientes();
            }
            printDbgEnd("pop");
            Console.WriteLine("poping from stack: " + this.stack[this.stackTop]);
            return this.stack[this.stackTop];
        }

        public float Operacion() {
            printDbgBegin("Operacion");
            while (!FinDeEntrada()) {
                if (char.IsDigit(Actual())) {
                    push(getInt());
                    Avanzar();
                    //return Operacion();
                } else if (Actual() == '+') {
                    Avanzar();
                    float b = pop();
                    float a = pop();
                    Console.WriteLine("adding " + a + " + " + b);
                    push(a + b);
                } else if (Actual() == '-') {
                    Avanzar();
                    float b = pop();
                    float a = pop();
                    Console.WriteLine("adding " + a + " - " + b);
                    push(a - b);
                } else if (Actual() == '*') {
                    Avanzar();
                    float b = pop();
                    float a = pop();
                    Console.WriteLine("adding " + a + " / " + b);
                    push(a * b);
                } else if (Actual() == '/') {
                    Avanzar();
                    float b = pop();
                    float a = pop();
                    push(a / b);
                } else if (Actual() == '%') {
                    Avanzar();
                    float b = pop();
                    float a = pop();
                    push(a % b);
                } else {
                    throw new SintaxisError();
                }
                // float resultado = Operacion();
                printDbgEnd("Operacion");
            }
            return pop();
        }
    }
}