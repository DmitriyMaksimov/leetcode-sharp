namespace leetcode_sharp;

// 1269. Number of Ways to Stay in the Same Place After Some Steps
// https://leetcode.com/problems/number-of-ways-to-stay-in-the-same-place-after-some-steps
public class S01269
{
    public int NumWays(int steps, int arrLen)
    {
        const int kMod = 1_000_000_007;
        var n = Math.Min(arrLen, steps / 2 + 1);
        var dp = new long[n];
        dp[0] = 1;

        while (steps-- > 0)
        {
            var newDp = new long[n];

            for (var i = 0; i < n; ++i)
            {
                newDp[i] = dp[i];

                if (i - 1 >= 0)
                {
                    newDp[i] += dp[i - 1];
                }

                if (i + 1 < n)
                {
                    newDp[i] += dp[i + 1];
                }

                // Take the modulo to avoid integer overflow.
                newDp[i] %= kMod;
            }

            dp = newDp;
        }

        return (int) dp[0];
    }
}