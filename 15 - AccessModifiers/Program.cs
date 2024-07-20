using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Before use another project from the solution you have to add references first

namespace _15___AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    //As a default, classes are internal
    //Classes can not be private except in nested classes
    class Customer
    {
        //Use protected inside of classes only 
        //Protected can be used for inherited classes but private can't
        private int Id { get; set; }

        public void Save()
        {

        }

        public void Delete()
        {

        }
    }

    class Student:Customer
    {
        public void Save2()
        {
            
            
        }
    }

    class Course
    {
        public string Name { get; set; }
    }


}
