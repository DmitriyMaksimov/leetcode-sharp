namespace leetcode_sharp;

// 2414. Length of the Longest Alphabetical Continuous Substring
// https://leetcode.com/problems/length-of-the-longest-alphabetical-continuous-substring
public class S02414
{
    public int LongestContinuousSubstring(string s)
    {
        var j = 0;
        var result = 1;

        for (var i = 1; i < s.Length; ++i)
        {
            if (s[i] != s[j] + i - j)
            {
                j = i;
            }

            result = Math.Max(result, i - j + 1);
        }

        return result;
    }
}
