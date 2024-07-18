using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06___Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intro();


            Console.ReadLine();
        }

        private static void Intro()
        {
            string city = "Ankara";
            string city2 = "İstanbul";


            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            //1 string result = city + city2;
            //Console.WriteLine(result);

            //2
            Console.WriteLine(String.Format(("{0}{1}"),city,city2));
        }
    }
}
