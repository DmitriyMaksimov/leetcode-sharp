namespace leetcode_sharp;

// 837. New 21 Game
// https://leetcode.com/problems/new-21-game/
public class S00837
{
    public double New21Game(int n, int k, int maxPts)
    {
        if (k == 0 || n >= k + maxPts)
        {
            return 1.0;
        }

        var windowSum = 1.0;
        var probability = 0.0;

        var dp = new double[n + 1];
        dp[0] = 1.0;

        for (var i = 1; i <= n; i++)
        {
            dp[i] = windowSum / maxPts;

            if (i < k)
            {
                windowSum += dp[i];
            }
            else
            {
                probability += dp[i];
            }

            if (i >= maxPts)
            {
                windowSum -= dp[i - maxPts];
            }
        }

        return probability;
    }
}