using System;

namespace Sum
{
    class Program
    {
        private static int add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        static void Main(string[] args)
        {
            Number firstNumber = new Number(2);
            Number secondNumber = new Number(3); 
            
            Number sum = firstNumber.add(secondNumber);
            Number difference = firstNumber.subtract(secondNumber);
            Number product = firstNumber.multiply(secondNumber);
            Number quotient = firstNumber.divide(secondNumber);
            Number remainder = firstNumber.getRemainder(secondNumber);
            
            Console.WriteLine($"Numbers are {firstNumber.getValue()} and {secondNumber.getValue()}");
            Console.WriteLine($"SimpleCalculator : {sum.getValue()}");
            Console.WriteLine($"Difference : {difference.getValue()}");
            Console.WriteLine($"Product : {product.getValue()}");
            Console.WriteLine($"Quotient : {quotient.getValue()}");
            Console.WriteLine($"Remainder : {remainder.getValue()}");
        }
    }
}