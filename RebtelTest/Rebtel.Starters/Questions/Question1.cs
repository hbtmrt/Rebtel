using System;

namespace Rebtel.Starters.Questions
{
    public sealed class Question1
    {
        public bool IsPowerOfTwo(int number)
        {
            if (number < 2)
            {
                return false;
            }

            double logOfNumber = Math.Log(number);
            double logOfTow = Math.Log(2);
            double divide = logOfNumber / logOfTow;

            var upperValue = Math.Ceiling(divide);
            var lowerValue = Math.Floor(divide);

            return upperValue == lowerValue;
        }
    }
}