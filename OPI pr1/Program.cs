using System;
using System.Runtime;
using System.Xml.Schema;

namespace MyApp
{
    internal class Program
    {
        static double fraction(float a, float b)
        {
            float sum;
            sum = a / b;
            return Math.Pow(sum, 3);

        }
        static void Main(string[] args)
        {
            int firstNumber;
            int secondNumber;

            Console.WriteLine("Enter first number");
            firstNumber =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(fraction(firstNumber, secondNumber));
        }
    }
}