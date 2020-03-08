using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 5, 7, 16, 1, 2 };
            ArrayAdditionI(arr);
            Console.ReadKey();

        }


        public static int ArrayAdditionI(int[] arr)
        {
            decimal datoTest = -100;
            decimal index = -1;
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > datoTest)
                {
                    datoTest = arr[i];
                    index = i;
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                if (datoTest == sum)
                {
                    Console.WriteLine("Verdadero");
                }
                else
                {
                    Console.WriteLine("Falso");
                }
            }

            return arr[0];
        }
    }
}
