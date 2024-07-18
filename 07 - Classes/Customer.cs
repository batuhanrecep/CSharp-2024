using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07___Classes
{
    internal class Customer
    {
        public int Id { get; set; }


        public string LastName { get; set; }

        public string City { get; set; }


        public string FirstName { get; set; }

        //OLD WAY

        //private string _firstname;


        //public string FirstName {
        //    get
        //    {
        //        return "Mr."+_firstname; 

        //    }
        //    set
        //    {
        //        _firstname = value;
        //    }
        //}
    }
}
