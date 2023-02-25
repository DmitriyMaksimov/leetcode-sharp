namespace leetcode_sharp;

// 121. Best Time to Buy and Sell Stock
// https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
public class S00121
{
    public int MaxProfit(int[] prices)
    {
        var cheapestPrice = int.MaxValue;
        var maxProfit = 0;

        foreach (var currentPrice in prices)
        {
            if (currentPrice < cheapestPrice)
            {
                cheapestPrice = currentPrice;
            }
            else
            {
                maxProfit = Math.Max(maxProfit, currentPrice - cheapestPrice);
            }
        }
        
        return maxProfit;
    }
}