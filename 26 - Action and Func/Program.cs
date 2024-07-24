using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _26___Action_and_Func
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //parameter, parameter, out
            Func<int, int, int> add = Sum;

            Console.WriteLine(add(5, 7));

            //out
            Func<int> getRandomNumber = delegate ()
            {
                Random random = new Random();
                return random.Next(1, 100);
            };

            Func<int> getRandomNumber2 = () => new Random().Next(1, 100);


            Console.WriteLine(getRandomNumber2());
            Thread.Sleep(200);
            Console.WriteLine(getRandomNumber());
            
            
            
            Console.ReadLine();
        }

        static int Sum(int x, int y)
        {
            return x + y;
        }
    }

}
