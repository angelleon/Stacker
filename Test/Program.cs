using System;
using Calculadorastack;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tests = {
                              /*
                              "5*6*7", // 210
                              "8%1-7", // -7
                              "5+1-1", // 5
                              "6-8*2", // -10
                              "0*9-5", //
                              "4/9/4", //
                              "1/9-8", //
                              "4%3+2", //
                              "0/5*5", //
                              "3-3/4", //
                              */
                              "56*7*",
                              "81-7%",
                              "51-1+",
                              "68-2*",
                              "09-5*",
                              "49/4/",
                              "19-8/",
                              "43%2+",
                              "05/5*",
                              "33-4/",
                             };
            foreach (string test in tests) {
                //Parser parser = new Parser(test);
                PosfijoParser parser = new PosfijoParser(test);
                Console.WriteLine("resultado: " + parser.Operacion() + "\n");
            }
        }
    }
}
