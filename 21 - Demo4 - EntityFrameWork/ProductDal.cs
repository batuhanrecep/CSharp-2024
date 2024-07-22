using System;
using System.Collections.Generic;
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
            using (ECommerceContext context = new ECommerceContext())
            {
                return context.Products.ToList();
            }
        }

        public void Add(Product product)
        {
            using (ECommerceContext context=new ECommerceContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
        }
    }
}
