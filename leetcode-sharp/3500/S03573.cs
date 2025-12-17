namespace leetcode_sharp;

// 3573. Best Time to Buy and Sell Stock V
// https://leetcode.com/problems/best-time-to-buy-and-sell-stock-v
public class S03573
{
    public long MaximumProfit(int[] prices, int k)
    {
        var n = prices.Length;
        
        if (n == 0 || k == 0)
        {
            return 0;
        }

        var prev = new long[k + 1, 3];
        var curr = new long[k + 1, 3];

        for (var t = 1; t <= k; t++)
        {
            prev[t, 0] = 0;
            prev[t, 1] = -prices[0];
            prev[t, 2] = prices[0];
        }

        for (var i = 1; i < n; i++)
        {
            for (var t = 1; t <= k; t++)
            {
                // Not holding (closed position)
                curr[t, 0] = Math.Max(Math.Max(prev[t, 0], prev[t, 1] + prices[i]), prev[t, 2] - prices[i]);

                // Holding long
                curr[t, 1] = Math.Max(prev[t, 1], prev[t - 1, 0] - prices[i]);
                
                // Holding short
                curr[t, 2] = Math.Max(prev[t, 2], prev[t - 1, 0] + prices[i]);
            }

            (prev, curr) = (curr, prev);
        }

        // We must end with no open position
        return prev[k, 0];
    }
}