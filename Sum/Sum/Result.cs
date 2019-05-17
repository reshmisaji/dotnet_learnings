using System;

namespace McKinsey.Calculator
{
    public class Result
    {
        private readonly Number _result;

        public Result(Number result)
        {
            _result = result;
        }

        public void Display()
        {
            Console.WriteLine(_result.GetValue());
        }

        public int GetValue()
        {
            return _result.GetValue();
        }
    }
}