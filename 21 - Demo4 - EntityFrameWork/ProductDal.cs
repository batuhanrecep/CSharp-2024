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