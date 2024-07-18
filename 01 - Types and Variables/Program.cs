using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___Types_and_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Value Types


            int x = 2147483647; //sınır - 32bit 
            long y = 9223372036854775807; //sınır (19karakter) - 64 bit 
            short z = 32767; //16bit 
            byte t = 255; //0-255 arası - 8bit/1byte
            bool condition = true;
            char character = 'a';
            string sehir = "Ankara";
            double a = 21.5; //64bit virgülden sonra 16 değer
            decimal b = 25.56m; //64bit  virgülden sonra 28değer
            var c = 10;
            c = 'A';

            Console.WriteLine("X is {0}", x);
            Console.WriteLine("Y is {0}", y);
            Console.WriteLine("Z is {0}", z);
            Console.WriteLine("T is {0}", t);
            Console.WriteLine("Condition is {0}", condition);
            Console.WriteLine("Character is {0}", (int)character);
            Console.WriteLine("A is {0}", a);
            Console.WriteLine("B is {0}", b);
            Console.WriteLine((int)Days.Friday);
            Console.WriteLine(Days.Friday);
            Console.WriteLine((int)Days.Monday);
            Console.WriteLine("C is {0}",c);
            Console.ReadLine();
           
        }
    }
    enum Days
    {
        Monday=10, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
}
