namespace Sum
{
    public class Number
    {
        private int number;

        public Number(int number)
        {
            this.number = number;
        }

        public Number add(Number secondNumber)
        {
            return new Number(this.number + secondNumber.number);
        }

        public int getValue()
        {
            return this.number;
        }

        public Number subtract(Number secondNumber)
        {
            return new Number(this.number - secondNumber.number);
        }

        public Number multiply(Number secondNumber)
        {
            return new Number(this.number * secondNumber.number);
        }

        public Number divide(Number secondNumber)
        {
            return new Number(this.number / secondNumber.number);
        }

        public Number getRemainder(Number secondNumber)
        {
            return new Number(this.number % secondNumber.number);
        }
    }
}