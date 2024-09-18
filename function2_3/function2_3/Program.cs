using System;
using System.Linq.Expressions;
using System.Reflection;

namespace function2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
        }


        static string Function2(double Function1)
        {
            if (Function1 >= 90 && Function1 <= 100)
            {
                return "A";
            }
            else if (Function1 >= 80 && Function1 <= 89)
            {
                return "B";
            }
            else if (Function1 >= 70 && Function1 <= 79)
            {
                return "C";
            }
            else if (Function1 >= 60 && Function1 <= 69)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }
        
    }
}
       