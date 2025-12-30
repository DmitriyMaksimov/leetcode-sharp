namespace leetcode_sharp;

// 3652. Best Time to Buy and Sell Stock using Strategy
// https://leetcode.com/problems/best-time-to-buy-and-sell-stock-using-strategy
public class S03752
{
    public long MaxProfit(int[] prices, int[] strategy, int k)
    {
        var n = prices.Length;
        var baseProfit = 0L;

        for (var i = 0; i < n; i++)
        {
            baseProfit += (long)strategy[i] * prices[i];
        }

        var psProfit = new long[n];
        var psPriceSum = new long[n];
        var cumulativeProfit = 0L;
        var cumulativePrices = 0L;

        for (var i = 0; i < n; i++)
        {
            cumulativeProfit += (long)strategy[i] * prices[i];
            cumulativePrices += prices[i];
            psProfit[i] = cumulativeProfit;
            psPriceSum[i] = cumulativePrices;
        }

        var ssProfit = new long[n];
        var suffixProfit = 0L;

        for (var i = n - 1; i >= 0; i--)
        {
            suffixProfit += (long)strategy[i] * prices[i];
            ssProfit[i] = suffixProfit;
        }

        var result = baseProfit;

        for (var i = 0; i + k <= n; i++)
        {
            var before = (i > 0) ? psProfit[i - 1] : 0;
            var after = (i + k < n) ? ssProfit[i + k] : 0;
            var totalWindowSecondHalf = psPriceSum[i + k - 1] - psPriceSum[i + (k / 2) - 1];
            var profitWithWindow = before + after + totalWindowSecondHalf;

            result = Math.Max(result, profitWithWindow);
        }

        return result;
    }
}