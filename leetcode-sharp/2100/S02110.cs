namespace leetcode_sharp;

// 2110. Number of Smooth Descent Periods of a Stock
// https://leetcode.com/problems/number-of-smooth-descent-periods-of-a-stock
public class S02110
{
    public long GetDescentPeriods(int[] prices)
    {
        var result = 1L;
        var count = 1L;

        for (var i = 1; i < prices.Length; ++i)
        {
            if (prices[i - 1] == prices[i] + 1)
            {
                ++count;
            }
            else
            {
                count = 1;
            }

            result += count;
        }

        return result;
    }
}
