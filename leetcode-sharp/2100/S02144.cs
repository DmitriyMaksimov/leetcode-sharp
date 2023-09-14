namespace leetcode_sharp;

// 2144. Minimum Cost of Buying Candies With Discount
// https://leetcode.com/problems/minimum-cost-of-buying-candies-with-discount/
public class S02144
{
    public int MinimumCost(int[] cost)
    {
        Array.Sort(cost);

        var sum = 0;
 
        for (int i = cost.Length - 1, count = 1; i >= 0; i--, ++count)
        {
            if (count % 3 != 0)
            {
                sum += cost[i];
            }
        }

        return sum;
    }
}