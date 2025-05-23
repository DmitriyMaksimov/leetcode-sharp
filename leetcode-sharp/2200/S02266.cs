namespace leetcode_sharp;

// 2266. Count Number of Texts
// https://leetcode.com/problems/count-number-of-texts
public class S02266
{
    private const int Mod = 1_000_000_007;

    public int CountTexts(string pressedKeys)
    {
        var n = pressedKeys.Length;
        var dp = new int[n + 1];
        dp[0] = 1;

        for (var i = 1; i <= n; i++)
        {
            dp[i] = dp[i - 1];

            if (i - 2 >= 0 && pressedKeys[i - 1] == pressedKeys[i - 2])
            {
                dp[i] = (dp[i] + dp[i - 2]) % Mod;
            }

            if (i - 3 >= 0 && pressedKeys[i - 1] == pressedKeys[i - 2] && pressedKeys[i - 1] == pressedKeys[i - 3])
            {
                dp[i] = (dp[i] + dp[i - 3]) % Mod;
            }

            if (pressedKeys[i - 1] == '7' || pressedKeys[i - 1] == '9')
            {
                if (i - 4 >= 0 && pressedKeys[i - 1] == pressedKeys[i - 2] && pressedKeys[i - 1] == pressedKeys[i - 3] && pressedKeys[i - 1] == pressedKeys[i - 4])
                {
                    dp[i] = (dp[i] + dp[i - 4]) % Mod;
                }
            }
        }

        return dp[n];
    }
}
