using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02___Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = 15;

            if (number == 10)
            {
                Console.WriteLine("Number is 10");

            }
            else if (number > 10)
            {

            }
            else
            {
                Console.WriteLine("Number is not 10");
            }

            //resharper can convert it to single line statement like this easily
            Console.WriteLine(number == 10 ? "Number is 10" : "Number is not 10");


            switch (number)
            {
                case 5:
                    Console.WriteLine("Number is 10");
                    break;
                case 6:
                    Console.WriteLine("Number is 20");
                    break;
                default:
                    Console.WriteLine("Number is 1011");
                    break;
            }

            if (number >= 0 && number <= 100)
            {
                Console.WriteLine("Number is between 0-100");
            }
            else if (number > 100 && number <= 200)
            {
                Console.WriteLine("Number is between 101-200");
            }
            else if (number > 200 || number < 0)
            {
                Console.WriteLine("Number is less than 0 or greater than 200");
            }

            //if (number < 100)
            //{
            //    if (number >= 90 && number < 95)
            //    {


            //    }
            //    else
            //    {

            //    }
            //}


            Console.ReadLine();

        }
    }
}
