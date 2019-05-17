namespace McKinsey.Calculator
{
    public class Number
    {
        private readonly int _value;

        public Number(int value)
        {
            _value = value;
        }

        public int GetValue()
        {
            return _value;
        }

    }
}