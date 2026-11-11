namespace leetcode_sharp;

// 3789. Minimum Cost to Acquire Required Items
// https://leetcode.com/problems/minimum-cost-to-acquire-required-items
public class S03789
{
    public long MinimumCost(int cost1, int cost2, int costBoth, int need1, int need2)
    {
        return Math.Max(Bound(need1, cost1, need2, cost2, costBoth), Bound(need2, cost2, need1, cost1, costBoth));
    }

    private static long Bound(long needA, int costA, long needB, int costB, int costBoth)
    {
        var pA = Math.Min(costA, costBoth);
        var pB = Math.Min(costB, costBoth - pA);
        return needA * pA + needB * pB;
    }
}