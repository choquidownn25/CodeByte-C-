using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderByte_04
{
    class Program
    {
        /// <summary>
        /// Metodo para calcular
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static int Calculo(int x, int y)
        {
            if (y == 0)
                return 1;
            else
                return x * Calculo(x, y - 1); ///usando la recursividad.
        }
        static void Main(string[] args)
        {
            int Numero, Potencia;
            int resultado;
            Console.Write("\n\n Calcular potencia de cualquier número  :\n");
            Console.Write(" Ingrese el valor base : ");
            Numero = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Ingrese el exponente: ");
            Potencia = Convert.ToInt32(Console.ReadLine());

            resultado = Calculo(Numero, Potencia);//Lllamando la funcion Calculo

            Console.Write(" El valor de {0} Potencia  {1} es : {2} \n\n", Numero, Potencia, resultado);

            Console.ReadKey();
        }
    }
}
