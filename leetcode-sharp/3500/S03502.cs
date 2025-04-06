namespace leetcode_sharp;

// 3502. Minimum Cost to Reach Every Position
// https://leetcode.com/problems/minimum-cost-to-reach-every-position
public class S03502
{
    public int[] MinCosts(int[] cost)
    {
        var result = new int[cost.Length];

        for (var i = 0; i < result.Length; i++)
        {
            result[i] = Math.Min(i > 0 ? result[i - 1] : int.MaxValue, cost[i]);
        }

        return result;
    }
}
