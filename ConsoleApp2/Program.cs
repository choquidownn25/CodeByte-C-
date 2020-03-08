using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        // A utility function to check if 
        // a given character is operand  
        static bool isOperand(char c)
        {
            return (c >= '0' && c <= '9');

        }
        // utility function to find value of and operand  
        static int value(char c) { return (int)(c - '0'); }
        public static string Calculator(string str)
        {


            // Base Case: Given expression is empty  
            if (str.Length == 0) return Convert.ToString("-1");

            // The first character must be 
            // an operand, find its value  
            int res = value(str[0]);

            // Traverse the remaining characters in pairs  
            for (int i = 1; i < str.Length; i += 2)
            {
                // The next character must be an operator, and  
                // next to next an operand  
                char opr = str[i], opd = str[i + 1];

                // If next to next character is not an operand  
                if (isOperand(opd) == false) return Convert.ToString("-1");

                // Update result according to the operator  
                if (opr == '+') res += value(opd);
                else if (opr == '-') res -= value(opd);
                else if (opr == '*') res *= value(opd);
                else if (opr == '/') res /= value(opd);

                // If not a valid operator  
                else return Convert.ToString("-1"); 
            }


            return str;

        }

        static void Main(string[] args)
        {
            string expr = Console.ReadLine();
            Calculator(expr); 

        }




    }
}
