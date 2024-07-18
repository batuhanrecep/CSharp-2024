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
            string sentence = "My name is Batuhan Recep";

            var result1 = sentence.Length;
            var result2 = sentence.Clone();
            sentence = "My name is Batuhan ";
          
            bool result3 = sentence.EndsWith("p");
            bool result4 = sentence.StartsWith("My name");

            var result5 = sentence.IndexOf("Namee");
            var result6 = sentence.IndexOf(" ");
            var result7 = sentence.LastIndexOf(" ");
            var result8 = sentence.Insert(0, "Hello");
            var result9 = sentence.Substring(3, 4);
            var result10 = sentence.ToLower();
            var result11 = sentence.ToUpper();
            var result12 = sentence.Replace(" ", "-");
            var result13 = sentence.Remove(2, 5);

            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(result4);
            Console.WriteLine(result5);
            Console.WriteLine(result6);
            Console.WriteLine(result7);
            Console.WriteLine(result8);
            Console.WriteLine(result9);
            Console.WriteLine(result10);
            Console.WriteLine(result11);
            Console.WriteLine(result12);
            Console.WriteLine(result13);
            Console.ReadLine();

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
