namespace leetcode_sharp;

// 712. Minimum ASCII Delete Sum for Two Strings
// https://leetcode.com/problems/minimum-ascii-delete-sum-for-two-strings/
public class S00712
{
    private int[,] _dp;

    public int MinimumDeleteSum(string s1, string s2)
    {
        var n = s1.Length;
        var m = s2.Length;

        _dp = new int[n + 1, m + 1];

        for (var i = 0; i <= n; i++)
        {
            for (var j = 0; j <= m; j++)
            {
                _dp[i, j] = -1;
            }
        }

        return solve(s1, s2, 0, 0);
    }

    private int solve(string s1, string s2, int i, int j)
    {
        if (_dp[i, j] != -1)
            return _dp[i, j];

        if (i == s1.Length)
        {
            var sum = 0;
            for (var k = j; k < s2.Length; k++)
            {
                sum += s2[k];
            }

            return sum;
        }

        if (j == s2.Length)
        {
            var sum = 0;
            for (var k = i; k < s1.Length; k++)
            {
                sum += s1[k];
            }

            return sum;
        }

        var nt = Math.Min(s1[i] + solve(s1, s2, i + 1, j), s2[j] + solve(s1, s2, i, j + 1));
        var tk = int.MaxValue;
        if (s1[i] == s2[j])
        {
            tk = solve(s1, s2, i + 1, j + 1);
        }

        return _dp[i, j] = Math.Min(nt, tk);
    }
}