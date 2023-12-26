namespace leetcode_sharp;

// 1155. Number of Dice Rolls With Target Sum
// https://leetcode.com/problems/number-of-dice-rolls-with-target-sum
public class S01155
{
    private const int Mod = 1_000_000_007;

    public int NumRollsToTarget(int n, int k, int target)
    {
        var dp = new int[n + 1, target + 1];
        for (var i = 0; i <= n; i++)
        {
            for (var j = 0; j <= target; j++)
            {
                dp[i, j] = -1;
            }
        }

        return recursion(dp, n, k, target);
    }

    private static int recursion(int[,] dp, int n, int k, int target)
    {
        if (target == 0 && n == 0)
        {
            return 1;
        }

        if (n == 0 || target <= 0)
        {
            return 0;
        }

        if (dp[n, target] != -1)
        {
            return dp[n, target] % Mod;
        }

        var ways = 0;
        for (var i = 1; i <= k; i++)
        {
            ways = (ways + recursion(dp, n - 1, k, target - i)) % Mod;
        }

        return dp[n, target] = ways % Mod;
    }
}