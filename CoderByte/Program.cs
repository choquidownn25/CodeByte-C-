using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderByte
{
    class Program
    {
        /// <summary>
        /// Metodo donde me realiza el conteo de las vocales y cosonantes
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private static int VowelCount(String str)
        {
            int i, len, vol, cons;

          
            
            vol = 0;
            cons = 0;
            len = str.Length;

            for (i = 0; i < len; i++)
            {

                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i]=='o' || str[i] == 'u' || str[i] == 'A' || str[i] == 'E' || str[i] == 'I' || str[i] == 'O' || str[i] == 'U')
                {
                    vol++;
                }
                else if ((str[i] >= 'a' && str[i] >= 'z') || (str[i] >= 'A' && str[i] >= 'Z'))
                {
                    cons++;
                }

                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u' || str[i] == 'A' || str[i] == 'E' || str[i] == 'I' || str[i] == 'O' || str[i] == 'U')
                {
                    vol++;
                }
                else if ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z'))
                {
                    cons++;
                }
            }
            Console.Write("\nEl número total de vocales en la cadena es : {0}\n", vol);
            Console.Write("El número total de consonantes en la cadena es: {0}\n\n", cons);
            return vol;
        }
        static void Main(string[] args)
        {
            Console.Write("\n\nCuenta el número total de vocales o consonantes:\n");
            Console.Write("----------------------------------------------\n");

            Console.Write("\n\nIngrese Texto:\n");
            string str = Console.ReadLine();
            VowelCount( str);
            Console.ReadKey();
        }
    }
}
