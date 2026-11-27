namespace leetcode_sharp;

// 3946. Maximum Number of Items From Sale I
// https://leetcode.com/problems/maximum-number-of-items-from-sale-i
public class S03946
{
    public int MaximumSaleItems(int[][] items, int budget)
    {
        var factors = items.Select(item => item[0]).ToArray();
        var prices = items.Select(item => item[1]).ToArray();
        var top = factors.Max();
        var have = new int[top + 1];
        var gains = new int[top + 1];

        foreach (var factor in factors)
        {
            have[factor]++;
        }

        for (var factor = 1; factor <= top; factor++)
        {
            for (var multiple = factor; multiple <= top; multiple += factor)
            {
                gains[factor] += have[multiple];
            }
        }

        var cheapest = prices.Min();
        var best = new int[budget + 1];

        for (var money = 0; money <= budget; money++)
        {
            best[money] = money / cheapest;
        }

        foreach (var item in items)
        {
            var factor = item[0];
            var price = item[1];
            var gain = gains[factor];

            if (gain > price / cheapest)
            {
                for (var money = budget; money >= price; money--)
                {
                    best[money] = Math.Max(best[money], best[money - price] + gain);
                }
            }
        }

        return best[budget];
    }
}