using Rebtel.Starters.Questions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Rebtel.Starters
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            // Question 1
            var question1 = new Question1();
            bool isPowerOfTwoTest1 = question1.IsPowerOfTwo(64); // returns true
            bool isPowerOfTwoTest2 = question1.IsPowerOfTwo(65); // returns false

            // Question 2
            string reversed = new Question2().Reverse("Rebtel");

            //Question 3
            string replicatedString = new Question3().ReplicateString("HI", 3);

            // Question 4: with multiple processors.
            List<int> oddNumbers = await new Question4().GetOddNumbersAsync(1, 100);
        }
    }
}