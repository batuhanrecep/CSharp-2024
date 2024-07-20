using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17___ReferenceAndValueType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Value Type
            int number1 = 10;
            int number2 = 20;
            number2 = number1;
            number1 = 30;

            Console.WriteLine(number2);

            //Reference Types: Classes, Arrays, Interfaces, Strings, Abstract Classes
            string[] cities1 = new string[] { "Ankara", "Adana", "Afyon" };
            string[] cities2 = new string[] { "Bursa", "Bolu", "balıkesir" };
            cities2 = cities1;
            cities1[0] = "İstanbul";

            foreach (var cities in cities2)
            {
                Console.WriteLine(cities);
            }



            //Common mistake that developers made
            //Correct way
            DataTable dataTable1 = new DataTable();
            DataTable dataTable2;
            dataTable2 = dataTable1;

            //False way
            DataTable dataTable3 = new DataTable();
            DataTable dataTable4 = new DataTable();
            dataTable4 = dataTable3;

            Console.ReadLine();
        }
    }

    

}
