using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stack
{
    class Pilas
    {







        // valor maximo ultimo 
        private int limite;
        // valor o prime valor en salir
        private int ultimo;
        //vector que va almacenada la pila
        private int[] la_pila;
        //connstructor parametros vacios
        public Pilas() { }
        public Pilas(int lim)
        {
            la_pila = new int[lim];
            limite = lim;
            ultimo = -1;

        }




        public Boolean pila_llena()
        {
            if (ultimo == limite - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean pila_vacia()
        {
            if (ultimo == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void push(int n)
        {
            if (pila_llena() == true)
            {
                // Pila LLena
            }
            else
            {
                ultimo++; la_pila[ultimo] = n;
            }







        }



        public int pop()
        {






            int n = 0;
            if (pila_vacia() == true)
            {

                // Pilla vacia
                return n;
            }
            else
            {
                n = la_pila[ultimo];
                ultimo--;
                return n;
            }

       



        }






    }
}
