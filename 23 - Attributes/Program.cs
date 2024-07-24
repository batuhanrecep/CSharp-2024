using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace _23___Attributes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer {Id=1, LastName = "Demir", Age=1};
            CustomerDal customerDal= new CustomerDal();
            customerDal.Add(customer);



            Console.ReadLine(); 
        }
    }
    [ToTable("Customers")]
    class Customer
    {
        public int Id { get; set; }
        [RequiredProperty]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
    
    class CustomerDal
    {
        [Obsolete("Don't use Add, instead use AddNew Method")] //Predefined Attribute
        public void Add(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} added!", customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }

        public void AddNew(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} added!", customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }
    }

    //Custom Attributes - These are must be inherited from Attribute Class 
    class RequiredPropertyAttribute : Attribute
    {

    }
    class ToTableAttribute : Attribute
    {
        //With ReSharper
        //private string v;
        //public ToTableAttribute(string v)
        //{
        //    this.v = v;
        //}

        private string _tableName;

        public ToTableAttribute(string tableName)
        {
            _tableName = tableName;
        }
    }


}
