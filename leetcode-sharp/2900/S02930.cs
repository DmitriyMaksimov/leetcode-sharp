namespace leetcode_sharp;

// 2930. Number of Strings Which Can Be Rearranged to Contain Substring
// https://leetcode.com/problems/number-of-strings-which-can-be-rearranged-to-contain-substring
public class S02930
{
    private const long MOD = 1_000_000_007L;
    private long[,,,] dp;

    public int StringCount(int n)
    {
        dp = new long[n + 1, 2, 3, 2];

        for (var i = 0; i <= n; i++)
        {
            for (var j = 0; j < 2; j++)
            {
                for (var k = 0; k < 3; k++)
                {
                    for (var m = 0; m < 2; m++)
                    {
                        dp[i, j, k, m] = -1;
                    }
                }
            }
        }

        return (int)Solve(n, 1, 2, 1);
    }

    private long Solve(int n, int l, int e, int t)
    {
        if (n == 0)
        {
            return l == 0 && e == 0 && t == 0 ? 1L : 0L;
        }

        if (dp[n, l, e, t] != -1)
        {
            return dp[n, l, e, t];
        }

        var ans = Solve(n - 1, l, e, t) * 23L % MOD;
        ans = (ans + Solve(n - 1, Math.Max(0, l - 1), e, t)) % MOD;
        ans = (ans + Solve(n - 1, l, Math.Max(0, e - 1), t)) % MOD;
        ans = (ans + Solve(n - 1, l, e, Math.Max(0, t - 1))) % MOD;

        return dp[n, l, e, t] = ans;
    }
}
