using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderByte_03
{
    class Program
    {
        /// <summary>
        /// Metodo de Ordenamiento
        /// </summary>
        /// <param name="sinorden">Ingreso de lista</param>
        /// <returns></returns>
        private static List<int> MergeSort(List<int> sinorden)
        {
            if (sinorden.Count <= 1)
                return sinorden;

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            int middle = sinorden.Count / 2;
            for (int i = 0; i < middle; i++)  //Dividiendo la lista sin clasificar
            {
                left.Add(sinorden[i]);
            }
            for (int i = middle; i < sinorden.Count; i++)
            {
                right.Add(sinorden[i]);
            }

            left = MergeSort(left);
            right = MergeSort(right);
            return Merge(left, right);
        }

        private static List<int> Merge(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();

            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left.First() <= right.First())  //Comparación de los primeros dos elementos para ver cuál es más pequeño
                    {
                        result.Add(left.First());
                        left.Remove(left.First());      //Resto de la lista menos el primer elemento
                    }
                    else
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if (left.Count > 0)
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)
                {
                    result.Add(right.First());

                    right.Remove(right.First());
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            List<int> sinorden = new List<int>();
            List<int> orden;

            Random random = new Random();

            Console.WriteLine("Elementos originales de la matriz: ");
            for (int i = 0; i < 10; i++)
            {
                sinorden.Add(random.Next(0, 100));
                Console.Write(sinorden[i] + " ");
            }
            Console.WriteLine();

            orden = MergeSort(sinorden);

            Console.WriteLine("Elementos de matriz ordenados: ");
            foreach (int x in orden)
            {
                Console.Write(x + " ");
            }
            Console.Write("\n");
            Console.Write("\n");
            Console.ReadKey();
        }
    }
}
