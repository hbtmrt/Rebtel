using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rebtel.Starters.Questions
{
    public sealed class Question4
    {
        public async Task<List<int>> GetOddNumbersAsync(int first, int last)
        {
            List<int> oddNumbers = new();

            List<Task<List<int>>> taskList = new();

            // choose as 5, it's our choice to set any number.
            int parallelRuns = 5;
            int chunkSize = (int)Math.Ceiling((double)(last - first + 1) / 5);

            for (int counter = 0; counter < parallelRuns; counter++)
            {
                int start = first + counter * chunkSize;
                int end = first + (counter + 1) * chunkSize - 1;

                if (end > last)
                {
                    end = last;
                }

                taskList.Add(FindOddNumbersAsync(start, end));
            }

            var oddNumbersArray = await Task.WhenAll(taskList);

            foreach (var item in oddNumbersArray)
            {
                oddNumbers.AddRange(item);
            }

            return oddNumbers.OrderBy(o => 0).ToList();
        }

        private async Task<List<int>> FindOddNumbersAsync(int start, int end)
        {
            List<int> oddNumbers = new();

            for (int counter = start; counter <= end; counter++)
            {
                if (counter % 2 == 1)
                {
                    // if odd
                    oddNumbers.Add(counter);
                }
            }

            return oddNumbers;
        }
    }
}