using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using _21___Demo3___EntityFrameWork;

namespace _21___Demo4___EntityFrameWork
{
    public class ProductDal
    {
        public List<Product> GetAll()
        {
            //With using without waiting garbage collector, we are disposing the object from memory. This happens when block ended
            using (ECommerceContext context = new ECommerceContext())
            {
                return context.Products.ToList();
            }
        }

        public List<Product> GetByName(string key)
        {
            //With using without waiting garbage collector, we are disposing the object from memory. This happens when block ended
            using (ECommerceContext context = new ECommerceContext())
            {
                return context.Products.Where(p=>p.Name.Contains(key)).ToList();
            }
        }

        public List<Product> GetByUnitPrice(decimal price)
        {
            //With using without waiting garbage collector, we are disposing the object from memory. This happens when block ended
            using (ECommerceContext context = new ECommerceContext())
            {
                return context.Products.Where(p => p.UnitPrice>=price).ToList();
            }
        }
        public List<Product> GetByUnitPrice(decimal min,decimal max)
        {
            //With using without waiting garbage collector, we are disposing the object from memory. This happens when block ended
            using (ECommerceContext context = new ECommerceContext())
            {
                return context.Products.Where(p => p.UnitPrice >= min && p.UnitPrice<=max).ToList();
            }
        }
        public Product GetById(int id)
        {
            //With using without waiting garbage collector, we are disposing the object from memory. This happens when block ended
            using (ECommerceContext context = new ECommerceContext())
            {
                //Single or Default
                //If there is two data that match, it will give exception
                //var result =  context.Products.SingleOrDefault(p => p.Id == id);

                //FirstOr Default
                //If there is more than one data that match, it will give the first one
                var result =  context.Products.FirstOrDefault(p => p.Id == id);
                return result;
            }
        }

        public void Add(Product product)
        {

            using (ECommerceContext context = new ECommerceContext())
            {
                //First way
                context.Products.Add(product);

                //Second way
                //var entity = context.Entry(product);
                //entity.State = EntityState.Added;


                context.SaveChanges();
            }
        }

        public void Update(Product product)
        {
            using (ECommerceContext context = new ECommerceContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Product product)
        {
            using (ECommerceContext context = new ECommerceContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

    }
}