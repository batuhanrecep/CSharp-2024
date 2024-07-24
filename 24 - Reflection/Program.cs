using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _24___Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Without Reflection
            //MathOperations mathOperations = new MathOperations(2,3);
            //Console.WriteLine(mathOperations.Sum2());
            //Console.WriteLine(mathOperations.Sum(3,4));

            //Reflection should not use for everything. Its an expensive object. Reflection should use when it needed
            var type = typeof(MathOperations);
            //First example, CreateInstance Method

            //MathOperations mathOperations =(MathOperations)Activator.CreateInstance(type,6,7);
            //Console.WriteLine(mathOperations.Sum2());
            //Console.WriteLine(mathOperations.Sum(11,12));

            //Second Example
            //With GetMethod, we can reach the method(Sum2) and we can invoke it with or without parameters
            var instance = Activator.CreateInstance(type, 6, 5);
            Console.WriteLine(instance.GetType().GetMethod("Sum2").Invoke(instance,null));


            MethodInfo methodInfo = instance.GetType().GetMethod("Sum2");
            Console.WriteLine(methodInfo.Invoke(instance, null));


            //With reflection, we can reach the features of an object's (Methods, attributes etc.)//
            var methods = type.GetMethods();

            foreach (var info in methods)
            {
                Console.WriteLine("Name of method : {0}",info.Name);
                foreach (var parameterInfo in info.GetParameters())
                {
                    Console.WriteLine("Parameters : {0}", parameterInfo.Name);
                }
                foreach (var attribute in info.GetCustomAttributes())
                {
                    Console.WriteLine("Attribute : {0}", attribute.GetType().Name);
                }
            }

            Console.ReadLine();
        }
    }

    public class MathOperations
    {
        private int _number1;
        private int _number2;

        public MathOperations(int number1, int number2)
        {
            _number1 = number1;
            _number2 = number2;
        }

        
        public int Sum(int number1, int number2)
        {
            return number1 + number2;
        }

        public int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        public int Sum2()
        {
            return _number1 + _number2;
        }

        [MethodName("Don't Multiply")]
        public int Multiply2()
        {
            return _number1 * _number2;
        }

    }

    public class MethodNameAttribute : Attribute
    {
        public MethodNameAttribute(string name)
        {
            
        }
    }

}
