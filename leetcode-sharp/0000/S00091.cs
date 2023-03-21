namespace leetcode_sharp;

// 91. Decode Ways
// https://leetcode.com/problems/decode-ways/
public class S00091
{
    public int NumDecodings(string s)
    {
        var n = s.Length;
        if (n == 0)
        {
            return 0;
        }

        var dp = new int[n + 1];
        dp[n] = 1;
        dp[n - 1] = s[n - 1] != '0' ? 1 : 0;

        for (var i = n - 2; i >= 0; i--)
        {
            if (s[i] != '0')
            {
                dp[i] = int.Parse(s.Substring(i, 2)) <= 26 ? dp[i + 1] + dp[i + 2] : dp[i + 1];
            }
        }

        return dp[0];
    }
}