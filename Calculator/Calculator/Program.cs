using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number : ");
            int firstNumber = Console.ReadLine();
            Console.WriteLine("Enter the second number : ");
            int secondNumber = Console.ReadLine();
            int sum = firstNumber + secondNumber;
            
            Console.WriteLine($"Sum of the numbers is : {sum}");
        }
    }
}