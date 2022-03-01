namespace Rebtel.Starters.Questions
{
    /// <summary>
    /// Time complexity = O(n)
    /// Space complexity = O(1)
    /// </summary>
    public sealed class Question2
    {
        public string Reverse(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return string.Empty;
            }

            char[] charArray = value.ToCharArray();
            int length = value.Length;
            char tempChar;

            for (int bottomCounter = 0, upperCounter = length - 1; bottomCounter < upperCounter; bottomCounter++, upperCounter--)
            {
                tempChar = charArray[bottomCounter];
                charArray[bottomCounter] = charArray[upperCounter];
                charArray[upperCounter] = tempChar;
            }

            return charArray.ToString();
        }
    }
}