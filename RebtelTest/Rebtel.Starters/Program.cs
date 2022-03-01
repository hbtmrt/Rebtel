using Rebtel.Starters.Questions;

namespace Rebtel.Starters
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Question 1
            var question1 = new Question1();
            bool isPowerOfTwoTest1 = question1.IsPowerOfTwo(64); // returns true
            bool isPowerOfTwoTest2 = question1.IsPowerOfTwo(65); // returns false
        }
    }
}