using System;
using System.Collections.Generic;
using System.Linq;
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
            MathOperations mathOperations =(MathOperations)Activator.CreateInstance(type,6,7);
            Console.WriteLine(mathOperations.Sum2());
            Console.WriteLine(mathOperations.Sum(11,12));
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

        public int Multiply2()
        {
            return _number1 * _number2;
        }

    }

}
