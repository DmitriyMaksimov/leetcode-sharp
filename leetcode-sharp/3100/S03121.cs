namespace leetcode_sharp;

// 3121. Count the Number of Special Characters II
// https://leetcode.com/problems/count-the-number-of-special-characters-ii
public class S03121
{
    public int NumberOfSpecialChars(string word)
    {
        var lastLowercasePosition = new Dictionary<char, int>();
        var firstUppercasePosition = new Dictionary<char, int>();

        for (var i = 0; i < word.Length; i++)
        {
            var ch = word[i];

            if (char.IsLower(ch))
            {
                lastLowercasePosition[ch] = i;
            }
            else
            {
                firstUppercasePosition.TryAdd(ch, i);
            }
        }

        var result = 0;

        for (var ch = 'a'; ch <= 'z'; ch++)
        {
            var firstUppercaseOccurence = firstUppercasePosition.GetValueOrDefault(char.ToUpper(ch), int.MinValue);
            var lastLowercaseOccurence = lastLowercasePosition.GetValueOrDefault(ch, int.MaxValue);
            if (lastLowercaseOccurence < firstUppercaseOccurence)
            {
                ++result;
            }
        }

        return result;
    }
}