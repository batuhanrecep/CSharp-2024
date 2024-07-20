using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace _19___Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //For exceptions, we should not use "e".Its against to best practices
            
            //1
            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
  
            }

            //2
            HandleException(() =>
            {
                Find();
            });



            //ExceptionIntro(); - Previous lesson
            Console.ReadLine();
        }

        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void Find()
        {
            List<string> students = new List<string> { "Kaan", "Nil", "Su" };


            if (!students.Contains("Ahmet"))
            {
                throw new RecordNotFoundException("Record not found");
            }
            else
            {
                Console.WriteLine("Record Found");
            }
        }

        private static void ExceptionIntro()
        {
            try
            {
                string[] students = new string[3] { "Nil", "Su", "Kaan" };
                students[3] = "Ahmet";
            }
            //catch (IndexOutOfRangeException exception)
            //{
            //    Console.WriteLine("EXCEPTIONN");
            //}
            //catch (DivideByZeroException e)
            //{

            //}
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine("EXCEPTIONN");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.InnerException);
            }
        }
    }

}
