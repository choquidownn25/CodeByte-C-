using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderByte_02
{
    class Program
    {
        /// <summary>
        /// Metodo Array
        /// </summary>
        /// <param name="a"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        private static int Array(int n)
        {
            int[] a  = new int[100];
            int i,  sum = 0;
            

            Console.Write("Elementos de entrada {0} n la matriz:\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("Elemento - {0} : ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                sum += a[i];
            }

            Console.Write("La suma de todos los elementos almacenados en la matriz es: {0}\n\n", sum);
            return sum;
        }

        static void Main(string[] args)
        {
            Console.Write("\n\nEncuentra la suma de todos los elementos de la matriz:\n");
            Console.Write("--------------------------------------\n");

            Console.Write("Ingrese el número de elementos que se almacenarán en la matriz: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Array(n);//Proceso

            Console.ReadKey();
        }

    }
}
