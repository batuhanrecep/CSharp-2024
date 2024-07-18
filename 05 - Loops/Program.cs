using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _05___Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ForLoop();
            //WhileLoop();
            //DoWhileLoop();
            //ForEachLoop();


            if (IsPrimeNumber(37))
            {
                Console.WriteLine("This is a prime number");
            }
            else
            {
                Console.WriteLine("This is not a prime number");
            }

            Console.ReadLine();
        }


        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number - 1; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                    i = number; //like break
                }

            }

            return result;
        }

        private static void ForEachLoop()
        {
            string[] students = new[] { "Engin", "Derin", "Salih" };

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        private static void DoWhileLoop()
        {
            int number = 10;

            do
            {
                Console.WriteLine(number);
                number--;
            } while (number >= 0);
        }

        private static void WhileLoop()
        {
            int number = 100;

            while (number >= 0)
            {
                number--;
                Console.WriteLine(number);

            }
        }

        private static void ForLoop()
        {
            for (int i = 0; i < 100; i += 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
