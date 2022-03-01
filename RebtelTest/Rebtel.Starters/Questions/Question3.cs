using System.Text;

namespace Rebtel.Starters.Questions
{
    public sealed class Question3
    {
        public string ReplicateString(string value, int noOfTimes)
        {
            return new StringBuilder(value.Length * noOfTimes).Insert(0, value, noOfTimes).ToString();
        }
    }
}