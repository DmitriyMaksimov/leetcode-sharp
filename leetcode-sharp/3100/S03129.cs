namespace leetcode_sharp;

// 3129. Find All Possible Stable Binary Arrays I
// https://leetcode.com/problems/find-all-possible-stable-binary-arrays-i
public class S03129
{
    private const int Mod = 1_000_000_007;

    public int NumberOfStableArrays(int zero, int one, int limit)
    {
        var dp = new long[zero + 1, one + 1, 2];

        for (var i = 1; i <= Math.Min(limit, zero); i++)
        {
            dp[i, 0, 0] = 1;
        }

        for (var j = 1; j <= Math.Min(limit, one); j++)
        {
            dp[0, j, 1] = 1;
        }

        for (var i = 1; i <= zero; i++)
        {
            for (var j = 1; j <= one; j++)
            {
                var subtract0 = (i - limit - 1 >= 0) ? dp[i - limit - 1, j, 1] : 0;
                var subtract1 = (j - limit - 1 >= 0) ? dp[i, j - limit - 1, 0] : 0;

                dp[i, j, 0] = (dp[i - 1, j, 0] + dp[i - 1, j, 1] - subtract0) % Mod;
                if (dp[i, j, 0] < 0) dp[i, j, 0] += Mod;

                dp[i, j, 1] = (dp[i, j - 1, 0] + dp[i, j - 1, 1] - subtract1) % Mod;
                if (dp[i, j, 1] < 0) dp[i, j, 1] += Mod;
            }
        }

        return (int)((dp[zero, one, 0] + dp[zero, one, 1]) % Mod);
    }
}