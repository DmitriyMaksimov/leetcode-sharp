namespace leetcode_sharp;

// 714. Best Time to Buy and Sell Stock with Transaction Fee
// https://leetcode.com/problems/best-time-to-buy-and-sell-stock-with-transaction-fee/
public class S00714
{
    public int MaxProfit(int[] prices, int fee)
    {
        if (prices.Length <= 1)
        {
            return 0;
        }

        var days = prices.Length;
        var buy = new int[days];
        var sell = new int[days];
        
        buy[0] = -prices[0];

        for (var i = 1; i < days; i++)
        {
            buy[i] = Math.Max(buy[i - 1], sell[i - 1] - prices[i]);
            sell[i] = Math.Max(sell[i - 1], buy[i - 1] + prices[i] - fee);
        }

        return sell[days - 1];
    }
}