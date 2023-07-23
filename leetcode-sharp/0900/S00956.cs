namespace leetcode_sharp;

// 956. Tallest Billboard
// https://leetcode.com/problems/tallest-billboard/
public class S00956
{
    public int TallestBillboard(int[] rods)
    {
        var sum = rods.Sum();
        var dp = new int[rods.Length + 1, sum + 1];

        for (var i = 1; i <= rods.Length; i++)
        {
            for (var j = 0; j <= sum; j++)
            {
                if (dp[i - 1, j] < j)
                {
                    continue;
                }

                dp[i, j] = Math.Max(dp[i, j], dp[i - 1, j]);

                var k = j + rods[i - 1];
                dp[i, k] = Math.Max(dp[i, k], dp[i - 1, j] + rods[i - 1]);

                k = Math.Abs(j - rods[i - 1]);
                dp[i, k] = Math.Max(dp[i, k], dp[i - 1, j] + rods[i - 1]);
            }
        }

        return dp[rods.Length, 0] / 2;
    }
}