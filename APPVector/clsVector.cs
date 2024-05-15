using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace APPVector
{
    class clsVector
    {
        //Propiedades del Vector
        private int[] vector;
        private int lg;

        //Constructor -> Inicializar las propiedades
        public clsVector(){
            vector = new int[100];
            lg = 0;
        }
        //Metodos (procediminetos o funciones)
        public void adicionar(int e){
            vector[lg] = e;
            lg = lg + 1;
        }
        // Obtener el valor en la posicion p
        public int obtenervalor(int pos) {
            return vector[pos];
        }
        //Longitud del vector
        public int longitud() {
            return lg;
        }
        // Invertit los elementos del vector
        public void invertir() {
            int fin = lg - 1;
            int mitad = lg / 2;
            int i = 0;
            int aux = 0;
            while (i < mitad){
                aux = vector[fin - i];
                vector[fin - i] = vector[i];
                vector[i] = aux;
                i++;
            }
        }

        //Cantidad de elementos Pares
        public int cantPares() {
            int cont = 0;
            for (int i = 0; i < lg; i++) {
                if (vector[i] % 2 == 0)
                    cont++;
            }
            return cont;
        }

        //Ordenar los elementos del vector de menor a mayor
        public void OrdenarMenorAmayor() {
            int aux = 0;
            for (int i = 0; i < lg; i++) { 
                for(int j = i; j < lg; j++) {
                    if(vector[i] > vector[j]) {
                        aux = vector[j];
                        vector[j] = vector[i];
                        vector[i] = aux;

                    }
                }
            }
        }

        //Eliminar el elemento de la pos. P
        public void EliminarElementoPos(int p) {
            for (int i = p - 1; i < lg; i++) {
                vector[i] = vector[i + 1];
            }
            lg = lg - 1;
        }

        //Invertir cada elemento del vector 
        public void InvertirCadaElementoVector()
        {
            int fin = lg - 1;
            int mitad = lg / 2;
            int i = 0;
            int aux = 0;
            while (i < mitad)
            {
                aux = vector[fin - i];
                vector[fin - i] = vector[i];
                vector[i] = aux;
                i++;
            }
            for (var j = lg; j < lg; j++);
         }
        
        //Cantidad de elementos capicua
        public int CantElementoCapicua()
        {
            int cap = 0;

            for (int i = 0; i < lg; i++)
            {
                int num = vector[i];
                int ac = 0;
                int aux = num;

                while (num > 0)
                {
                    int r = num % 10;
                    ac = (ac * 10) + r;
                    num = num / 10;
                }

                if (ac == aux)
                {
                    cap++;
                }
            }

            return cap;
        }

        //Cantidad de elementos primos

        public int CantElementoPrimo()
        {
            int cantidadElementosPrimos = 0;

            for (int i = 0; i < lg; i++)
            {
                int num = vector[i];
                int c = 0;

                for (int j = 1; j <= num; j++)
                {
                    if (num % j == 0)
                    {
                        c++;
                    }
                }

                if (c == 2)
                {
                    cantidadElementosPrimos++;
                }
            }

            return cantidadElementosPrimos;
        }
    }
}
