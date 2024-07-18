using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //We are using collections
            //1
            string[] students = new string[3];
            students[0] = "Engin";
            students[1] = "Derin";
            students[2] = "Salih";

            //2
            string[] students2 = new []{"Engin", "Derin", "Salih"};
            
            //3
            string[] students3 = { "Engin", "Derin", "Salih" };
            //students3[3] = "Ahmet"; //Pythonda ki gibi burda sonradan ekleme yapılamıyor en azından bu şekilde


            foreach (var student in students3)
            {
                Console.WriteLine(student);

            }

            //------------------------------------------------------------------------------------------------------------


            //Multi Dimensional Arrays


            string[,] regions = new string[5, 3]
            {
                { "Istanbul", "Izmit", "Balıkesir" },
                { "Ankara", "Konya", "Kırıkkale" },
                { "Antalya", "Adana", "Mersin" },
                { "Rize", "Trabzon", "Samsun" },
                { "Izmir", "Muğla", "Manisa" },

            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
                Console.WriteLine("*********");
            }


            Console.ReadLine();
        }
    }
}
