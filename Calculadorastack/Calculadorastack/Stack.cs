using System.Collections.Generic;

namespace Calculadorastack {
    public class Stack {
        private List<string> data;
        private int size;

        private int top;
        public Stack(int size) {
            this.data = new List<string>();
            this.size = size;
            this.top = 0;
        }

        public void push(string s) {
            this.data.Add(s);
        }

        public string pop() {
            return "";
        }


    } 
}