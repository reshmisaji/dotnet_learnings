namespace McKinsey.Calculator
{
    public class Calculator
    {
        public static Result Add(Number firstNumber, Number secondNumber)
        {
            var sum = new Number(firstNumber.GetValue() + secondNumber.GetValue());
            return new Result(sum);
        }

        public static Result Subtract(Number firstNumber, Number secondNumber)
        {
            var difference = new Number(firstNumber.GetValue() - secondNumber.GetValue());
            return new Result(difference);
        }

        public static Result Multiply(Number firstNumber, Number secondNumber)
        {
            var product = new Number(firstNumber.GetValue() * secondNumber.GetValue());
            return new Result(product);
        }

        public static Result Divide(Number firstNumber, Number secondNumber)
        {
            var quotient = new Number(firstNumber.GetValue() / secondNumber.GetValue());
            return new Result(quotient);
        }
    }
}