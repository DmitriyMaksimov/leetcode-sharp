namespace leetcode_sharp;

// 1297. Maximum Number of Occurrences of a Substring
// https://leetcode.com/problems/maximum-number-of-occurrences-of-a-substring
public class S01297
{
    public int MaxFreq(string s, int maxLetters, int minSize, int maxSize)
    {
        if (string.IsNullOrEmpty(s) || maxLetters == 0)
        {
            return 0;
        }

        var frequencies = new Dictionary<string, int>();
        var maxFrequency = 0;

        for (var i = 0; i <= s.Length - minSize; i++)
        {
            var currentSubstring = s.Substring(i, minSize);

            if (currentSubstring.Distinct().Count() <= maxLetters)
            {
                frequencies[currentSubstring] = frequencies.GetValueOrDefault(currentSubstring) + 1;
                maxFrequency = Math.Max(maxFrequency, frequencies[currentSubstring]);
            }
        }

        return maxFrequency;
    }
}
