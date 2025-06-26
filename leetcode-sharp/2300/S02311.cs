namespace leetcode_sharp;

// 2311. Longest Binary Subsequence Less Than or Equal to K
// https://leetcode.com/problems/longest-binary-subsequence-less-than-or-equal-to-k
public class S02311
{
    public int LongestSubsequence(string s, int k)
    {
        var zeros = s.Count(c => c == '0');
        var ones = 0;
        var value = 0L;
        var pow = 1L;

        for (var i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] == '1')
            {
                if (value + pow > k)
                {
                    continue;
                }

                value += pow;
                ones++;
            }

            pow <<= 1;

            if (pow > k)
            {
                break;
            }
        }

        return zeros + ones;
    }
}