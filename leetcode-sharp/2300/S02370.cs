namespace leetcode_sharp;

// 2370. Longest Ideal Subsequence
// https://leetcode.com/problems/longest-ideal-subsequence
public class S02370
{
    public int LongestIdealString(string s, int k)
    {
        var result = 0;
        var dp = new int[150];
        
        foreach (int n in s)
        {
            for (var j = n - k; j <= n + k; ++j)
            {
                dp[n] = Math.Max(dp[n], dp[j]);
            }

            result = Math.Max(result, ++dp[n]);
        }

        return result;
    }
}