namespace leetcode_sharp;

// 1525. Number of Good Ways to Split a String
// https://leetcode.com/problems/number-of-good-ways-to-split-a-string
public class S01525
{
    public int NumSplits(string s)
    {
        var rc = new int[26];
        var lc = new int[26];

        var right = s.Count(c => rc[c - 'a']++ == 0);
        var left = 0;

        var result = 0;

        foreach (var c in s)
        {
            if (lc[c - 'a']++ == 0)
            {
                left++;
            }

            if (--rc[c - 'a'] == 0)
            {
                right--;
            }

            if (left == right)
            {
                result++;
            }
        }

        return result;
    }
}
