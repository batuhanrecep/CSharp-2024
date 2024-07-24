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


        }
        class Product
        {

        }

        class Customer
        {
            
        }
        interface ICustomerDal:IRepository<Customer>
        {
            void Custom();
        }

        interface IProductDal:IRepository<Product>
        {
            
        }

        interface IRepository<T>
        {
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
