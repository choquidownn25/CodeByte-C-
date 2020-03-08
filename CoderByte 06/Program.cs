using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CoderByte_06
{
    class Program
    {
        public static string NumberSearch(string str)
        {

            int sum = 0;
            int leturaConteo = 0;
            for (int i = 0; i < str.Length; i++)
            {

                char c = str[i];

                if (Char.IsDigit(c))
                {
                    sum += Convert.ToInt32(Char.GetNumericValue(c));
                    Console.Write("Ingrese Texto : {0}\n", sum);
                }

                if (Char.IsLetter(c))
                {
                    leturaConteo++;
                }
            }

            

            return str;

        }
        static void Main(string[] args)
        {
            Console.Write("\n\nIngrese Texto:\n");
            string str = Console.ReadLine();
            NumberSearch(str);
            Console.ReadKey();
        }





       
    }
}
