using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderByte_05
{
    class Program
    {
        public static int ArrayAddition(int[] arr)
        {

            // code goes here  

            decimal datoTest = -100;

            int suma = 0;
            //Proceso

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > datoTest)
                {
                    datoTest = arr[i];

                }


            }
            //Se suma
            for (int i = 0; i < arr.Length; i++)
            {
                suma += arr[i];
                if (datoTest == suma)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }



            return arr[0];

        }
        static void Main(string[] args)
        {
            // keep this function call here
            Console.WriteLine("\n\nEncuentra la suma de todos los elementos de la matriz :\n");
            Console.WriteLine("Ingrese el numero de elementos que se almacenarán en la matriz : ");

            int[] arr = new int[10];
            ArrayAddition(arr);
            Console.WriteLine("\n");
            Console.ReadKey();
        }
    }
}
