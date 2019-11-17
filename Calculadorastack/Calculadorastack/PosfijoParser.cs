using System;

namespace Calculadorastack {
    public class PosfijoParser : ParserBase {
        private float[] stack;
        private int stackTop;

        private Stack operStack;

        //Array procedimiento = new Array[];

        public PosfijoParser(string operacionCruda) : base(operacionCruda) {
            this.stackTop = 0;
            this.stack = new float[operacionCruda.Length];
            this.operStack = new Stack(operacionCruda.Length);
            printDbg("operacionCruda " + operacionCruda);
        }

        public Stack getStack() {
            return this.operStack;
        }

        private void push(float val) {
            printDbgBegin("push");
            this.operStack.push("pushing into stack: " + val);
            this.stack[this.stackTop] = val;
            this.stackTop++;
        }

        private float pop() {
            this.stackTop--;
            if (this.stackTop < 0) {
                throw new ArgumentosInsuficientes();
            }
            printDbgEnd("pop");
            this.operStack.push("poping from stack: " + this.stack[this.stackTop]);
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
                    this.operStack.push("adding " + a + " + " + b);
                    push(a + b);
                } else if (Actual() == '-') {
                    Avanzar();
                    float b = pop();
                    float a = pop();
                    this.operStack.push("substracting " + a + " - " + b);
                    push(a - b);
                } else if (Actual() == '*') {
                    Avanzar();
                    float b = pop();
                    float a = pop();
                    this.operStack.push("multiplying " + a + " * " + b);
                    push(a * b);
                } else if (Actual() == '/') {
                    Avanzar();
                    float b = pop();
                    float a = pop();
                    this.operStack.push("dividing " + a + " / " + b);
                    push(a / b);
                } else if (Actual() == '%') {
                    Avanzar();
                    float b = pop();
                    float a = pop();
                    this.operStack.push("dividing " + a + " * " + b);
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