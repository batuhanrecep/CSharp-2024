using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22___Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();
            List<string> result = utilities.BuildList<string>("Ankara", "Adana", "izmir");

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            List<Customer> result2 = utilities.BuildList<Customer>(new Customer{FirstName = "Nil"},new Customer{FirstName = "Su"});

            foreach (var customer in result2)
            {
                Console.WriteLine(customer.FirstName);
            }
            Console.ReadLine();
        }

        class Utilities
        {
            public List<T> BuildList<T>(params T[] items)
            {
                return new List<T>(items);
            }
        }
        interface IEntity
        {

        }
        class Product : IEntity
        {

        }

        
        class Customer : IEntity
        {
            public string FirstName { get; set; }

        }
        interface ICustomerDal:IRepository<Customer>
        {
            void Custom();
        }

        interface IProductDal:IRepository<Product>
        {
            
        }
        //Interfaces, classes, abstract classes and also methods can be generics
        interface IRepository<T> where T : class,  IEntity, new() //Generic Constraints  // class means reference type and for value types we are using struct
        {                                                                                // T must be implemented from IEntity and can be used with new()
            List<T> GetAll();                                                            
            T Get(int id);
            void Add(T entity);
            void Delete(T entity);
            void Update(T entity);
        }

        class CustomerDal : ICustomerDal
        {
            public List<Customer> GetAll()
            {
                throw new NotImplementedException();
            }

            public Customer Get(int id)
            {
                throw new NotImplementedException();
            }

            public void Add(Customer entity)
            {
                throw new NotImplementedException();
            }

            public void Delete(Customer entity)
            {
                throw new NotImplementedException();
            }

            public void Update(Customer entity)
            {
                throw new NotImplementedException();
            }

            public void Custom()
            {
                throw new NotImplementedException();
            }
        }
        class ProductDal : IProductDal 
        {
            public List<Product> GetAll()
            {
                throw new NotImplementedException();
            }

            public Product Get(int id)
            {
                throw new NotImplementedException();
            }

            public void Add(Product entity)
            {
                throw new NotImplementedException();
            }

            public void Delete(Product entity)
            {
                throw new NotImplementedException();
            }

            public void Update(Product entity)
            {
                throw new NotImplementedException();
            }
        }

        
    }

}
