using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _21___Demo3___EntityFrameWork;

namespace _21___Demo4___EntityFrameWork
{
    public class ECommerceContext:DbContext
    {

        public DbSet<Product> Products { get; set; }


    }
}
