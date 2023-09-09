namespace leetcode_sharp;

// 1475. Final Prices With a Special Discount in a Shop
// https://leetcode.com/problems/final-prices-with-a-special-discount-in-a-shop/
public class S01475
{
    public int[] FinalPrices(int[] prices)
    {
        var result = new int[prices.Length];

        for (var i = 0; i < prices.Length; i++)
        {
            var discount = 0;
            for (var j = i + 1; j < prices.Length; j++)
            {
                if (prices[j] <= prices[i])
                {
                    discount = prices[j];
                    break;
                }
            }

            result[i] = prices[i] - discount;
        }

        return result;
    }
}