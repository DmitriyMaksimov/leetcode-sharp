namespace leetcode_sharp;

// 188. Best Time to Buy and Sell Stock IV
// https://leetcode.com/problems/best-time-to-buy-and-sell-stock-iv/
public class S00188
{
    private int[,,] _memo;
    private int[] _prices;
    
    public int MaxProfit(int k, int[] prices)
    {
        _memo = new int[prices.Length, 2, k + 1];
        _prices = prices;
        
        for (var i = 0; i < prices.Length; i++)
        {
            for (var j = 0; j <= k; j++)
            {
                _memo[i, 0, j] = -1;
                _memo[i, 1, j] = -1;
            }
        }

        return helper(0, 0, k);
    }

    private int helper(int index, int isBuying, int k)
    {
        if (index >= _prices.Length || k == 0)
        {
            return 0;
        }

        if (_memo[index, isBuying, k] != -1)
        {
            return _memo[index, isBuying, k];
        }

        if (isBuying == 0)
        {
            var buy = helper(index, 1, k) - _prices[index];
            var notBuy = helper(index + 1, 0, k);
            return _memo[index, isBuying, k] = Math.Max(buy, notBuy);
        }

        var sell = helper(index + 1, 0, k - 1) + _prices[index];
        var notSell = helper(index + 1, 1, k);
        return _memo[index, isBuying, k] = Math.Max(sell, notSell);
    }
}