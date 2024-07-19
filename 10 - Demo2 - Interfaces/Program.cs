using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10___Demo2___Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SOLID, Interface Segregation


            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot()
            };

            foreach (var worker in workers)
            {
                worker.Work();
            }

            IEat[] eats = new IEat[2]
            {
                new Manager(),
                new Worker()
            };

            foreach (var eat in eats)
            {
                eat.Eat();


            }

            Console.ReadLine();
        }

        interface IWorker
        {
            void Work();
        }

        interface ISalary
        {
            void GetSalary();
        }

        interface IEat
        {
            void Eat();
        }

        class Manager : IWorker, IEat, ISalary
        {
            public void Work()
            {
                Console.WriteLine("Manager works");
            }

            public void Eat()
            {
                Console.WriteLine("Manager eats");
            }

            public void GetSalary()
            {
                Console.WriteLine("Manager gets salary");
            }
        }

        class Worker : IWorker, ISalary, IEat
        {
            public void Work()
            {
                Console.WriteLine("Workers works");
            }

            public void GetSalary()
            {
                Console.WriteLine("Workers gets salary");
            }

            public void Eat()
            {
                Console.WriteLine("Workers eats");
            }
        }

        class Robot : IWorker
        {
            public void Work()
            {
                Console.WriteLine("Robots works");
            }
        }
    }
}
