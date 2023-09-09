using System.Text;

namespace leetcode_sharp;

// 1370. Increasing Decreasing String
// https://leetcode.com/problems/increasing-decreasing-string/
public class S01370
{
    public string SortString(string s)
    {
        const int maxChars = 26;

        var charCount = new int[maxChars];
        foreach (var c in s)
        {
            charCount[c - 'a']++;
        }

        var result = new StringBuilder();

        while (result.Length < s.Length)
        {
            for (var i = 0; i < maxChars; i++)
            {
                if (charCount[i] > 0)
                {
                    result.Append((char)('a' + i));
                    charCount[i]--;
                }
            }

            for (var i = maxChars - 1; i >= 0; i--)
            {
                if (charCount[i] > 0)
                {
                    result.Append((char)('a' + i));
                    charCount[i]--;
                }
            }
        }

        return result.ToString();
    }
}