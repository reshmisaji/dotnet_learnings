namespace McKinsey.Calculator
{
    internal static class Program
    {
        public static void Main()
        {
            var firstNumber = new Number(3);
            var secondNumber = new Number(2);

            var sum = Calculator.Add(firstNumber, secondNumber);
            sum.Display();    
        }
    }
}