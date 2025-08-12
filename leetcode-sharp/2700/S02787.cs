using System.Numerics;

namespace leetcode_sharp;

// 2787. Ways to Express an Integer as Sum of Powers
// https://leetcode.com/problems/ways-to-express-an-integer-as-sum-of-powers
public class S02787
{
    private const int Mod = 1_000_000_007;

    public int NumberOfWays(int n, int x)
    {
        var a = new List<int>();

        for (var nk = 1;; nk++)
        {
            var y = MsbfPow(nk, (uint)x);
            if (y > n)
            {
                break;
            }

            a.Add(y);
        }

        var dp = new int[n + 1];
        dp[0] = 1;

        foreach (var y in a)
        {
            for (var sum = n; sum >= y; sum--)
            {
                dp[sum] += dp[sum - y]; 
                if (dp[sum] >= Mod)
                {
                    dp[sum] -= Mod;
                }
            }
        }

        return dp[n];
    }

    private static int MsbfPow(int nk, uint x)
    {
        if (x == 1)
        {
            return nk;
        }

        // Find the position of the most significant bit in x
        var iN = 31 - BitOperations.LeadingZeroCount(x);
        long y = nk;

        for (var i = iN - 1; i >= 0; i--)
        {
            y = y * y % Mod;
            if (((x >> i) & 1) != 0)
            {
                y = y * nk % Mod;
            }
        }

        return (int)y;
    }
}