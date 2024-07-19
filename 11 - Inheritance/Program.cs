using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11___Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person[] persons = new Person[3]
            {
                new Customer { FirstName = "Batuhan"},
                new Student{FirstName = "Recep"},
                new Person{FirstName = "İrfan"}
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);


            }

            Console.ReadLine();
        }
    }

    class Person
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }

    interface IPerson
    {
        

    }

    class Customer : Person, IPerson
    {

        public string City { get; set; }

    }

    class Student : Person
    {
        public string Departmant { get; set; }
    }
}
