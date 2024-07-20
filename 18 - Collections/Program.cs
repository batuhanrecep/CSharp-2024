using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18___Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayAndArrayLists();
            //List();
            //Dictionary<id,customer>
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("book","kitap");
            dictionary.Add("computer", "bilgisayar");
            dictionary.Add("table", "masa");

           // Console.WriteLine(dictionary["table"]);


            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }

            Console.WriteLine(dictionary.ContainsKey("glass"));
            Console.WriteLine(dictionary.ContainsKey("table"));
            Console.WriteLine(dictionary.ContainsValue("glass"));
            Console.ReadLine();
        }

        private static void List()
        {
            //TypeSafe
            List<string> cities = new List<string>
            {
                "Ankara",
                "İstanbul"
            };
            Console.WriteLine(cities.Contains("Ankara"));

            foreach (var VARIABLE in cities)
            {
                Console.WriteLine(VARIABLE);
            }


            //1
            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer { id = 1, FirstName = "Batuhan" });
            //customers.Add(new Customer { id = 2, FirstName = "Recep" });


            //2
            List<Customer> customers = new List<Customer>
            {
                new Customer { id = 1, FirstName = "Batuhan" },
                new Customer { id = 2, FirstName = "Recep" }
            };

           
            var customer2 = new Customer { id = 3, FirstName = "Demir" };
            customers.Add(customer2);
            customers.AddRange(new Customer[2]
            {
                new Customer{id = 4,FirstName = "Salih"},
                new Customer{id = 5,FirstName = "Kaan"}
            });
            
            //customers.Clear();  

            //Common mistake this returns False because of value/reference type rules
            Console.WriteLine(customers.Contains(new Customer { id = 1, FirstName = "Batuhan"}));
            //Correct one
            Console.WriteLine(customers.Contains(customer2));

            var index=customers.IndexOf(customer2);
            Console.WriteLine(index);

            customers.Add(customer2);
            
            var lastIndex = customers.LastIndexOf(customer2);
            Console.WriteLine(lastIndex);

            customers.Insert(0,customer2);
            customers.Remove(customer2); //It will remove the first that he found
            customers.RemoveAll(c => c.FirstName == "Salih");



            var count = customers.Count;

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }

            Console.WriteLine("Count: {0}",count);
        }


        class Customer
        {
            public string FirstName { get; set; }
            public int id { get; set; }
        }










        private static void ArrayAndArrayLists()
        {
            //Problem of Arrays
            //Because of this problem we are using collections
            string[] citiesList = new string[2] { "Ankara", "İstanbul" };
            citiesList = new string[3];
            Console.WriteLine(citiesList[0]);



            //ArrayLists - These are not typesafe
            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("Adana");
            cities.Add("İstanbul");
            cities.Add(1.5);
            cities.Add('A');

            foreach (var VARIABLE in cities)
            {
                Console.WriteLine(VARIABLE);
            }
        }
    }


}
