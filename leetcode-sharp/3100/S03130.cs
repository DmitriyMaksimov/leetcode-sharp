namespace leetcode_sharp;

// 3130. Find All Possible Stable Binary Arrays II
// https://leetcode.com/problems/find-all-possible-stable-binary-arrays-ii
public class S03130
{
    private const int Mod = 1_000_000_007;

    public int NumberOfStableArrays(int zero, int one, int limit)
    {
        var dp = new int[zero + 1, one + 1, 2];

        for (var i = 0; i <= zero; i++)
        {
            if (i <= limit)
            {
                dp[i, 0, 0] = 1;
                dp[i, 0, 1] = 0;
            }
        }

        for (var j = 0; j <= one; j++)
        {
            if (j <= limit)
            {
                dp[0, j, 0] = 0;
                dp[0, j, 1] = 1;
            }
        }

        for (var i = 1; i <= zero; i++)
        {
            for (var j = 1; j <= one; j++)
            {
                var sumZero = (long)dp[i - 1, j, 0] + dp[i - 1, j, 1];
                var sumOne = (long)dp[i, j - 1, 0] + dp[i, j - 1, 1];

                dp[i, j, 0] = (int)(sumZero % Mod);
                dp[i, j, 1] = (int)(sumOne % Mod);

                if (i > limit)
                {
                    dp[i, j, 0] = (dp[i, j, 0] - dp[i - limit - 1, j, 1]) % Mod;
                }

                if (j > limit)
                {
                    dp[i, j, 1] = (dp[i, j, 1] - dp[i, j - limit - 1, 0]) % Mod;
                }

                if (dp[i, j, 0] < 0) dp[i, j, 0] += Mod;
                if (dp[i, j, 1] < 0) dp[i, j, 1] += Mod;
            }
        }

        return (int)(((long)dp[zero, one, 0] + dp[zero, one, 1]) % Mod);
    }
}