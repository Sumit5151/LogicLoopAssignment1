using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Pattrens
    {
        public void Pattern1(int limit)
        {
            Console.WriteLine("Pattern 1");
            for (int i = 1; i <= limit; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
        public void Pattern2(int limit)
        {
            Console.WriteLine("Pattern 2");
            for (int i = 1; i <= limit; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
            for (int i = limit; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }

        public void Factorial(int number)
        {
            
            int factorial = 1;
            for (int i = 1; i <=number; i++)
            {
                factorial=+ factorial* i;
            }
            Console.WriteLine("Factorial of the given number ={0}", factorial);
        }
    }
}
