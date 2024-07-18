using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07___Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();


            Customer customer = new Customer(); //resharper can easily transform to next one

            customer.City = "Ankara";
            customer.FirstName = "Batuhan";
            customer.LastName = "Recep";
            customer.Id = 1;


            Customer customer2 = new Customer
            {
                City = "Ankara",
                FirstName = "Batuhan2",
                Id = 1,
                LastName = "Recep2"
            };


            Console.WriteLine(customer2.FirstName);

            Console.ReadLine();

        }
    }




}
