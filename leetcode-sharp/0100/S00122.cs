namespace leetcode_sharp;

// 122. Best Time to Buy and Sell Stock II
// https://leetcode.com/problems/best-time-to-buy-and-sell-stock-ii/
public class S00122
{
    public int MaxProfit(int[] prices)
    {
        var result = 0;

        for (var i = 0; i < prices.Length - 1; i++)
        {
            if (prices[i + 1] > prices[i])
            {
                result += prices[i + 1] - prices[i];
            }
        }
        
        return result;
    }
}