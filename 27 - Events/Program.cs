using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _27___Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product harddisk = new Product(50);
            harddisk.ProductName = "Hard Disk";

            Product phone = new Product(50);
            phone.ProductName = "Samsung";
            phone.StockControlEvent += Phone_StockControlEvent;
            for (int i = 0; i < 10; i++)
            {
                harddisk.Sell(10);
                phone.Sell(10);
                Console.ReadLine();
            }


            Console.ReadLine();
        }

        private static void Phone_StockControlEvent()
        {
            Console.WriteLine("Phones are about to finish");
        }
    }

    public delegate void StockControl();
    public class Product
    {
        private int _stock;

        public Product(int stock)
        {
            _stock = stock;
        }

        public event StockControl StockControlEvent;
        public string ProductName { get; set; }

        public int Stock
        {
            get
            {
                return _stock;
            }
            set
            {
                _stock = value;
                if (value<=15 && StockControlEvent!=null)
                {
                    StockControlEvent();
                }
            }
        }

        public void Sell(int amount)
        {
            Stock -= amount;
            Console.WriteLine("{1} Stock Amount: {0}", Stock,ProductName);
        }
    }
}
