using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            var name =Console.ReadLine();
            Console.WriteLine($"Hello {name}!");
        }
    }
}