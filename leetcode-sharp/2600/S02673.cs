namespace leetcode_sharp;

// 2673. Make Costs of Paths Equal in a Binary Tree
// https://leetcode.com/problems/make-costs-of-paths-equal-in-a-binary-tree
public class S02673
{
    public int MinIncrements(int n, int[] cost)
    {
        var result = 0;

        for (var i = n / 2 - 1; i >= 0; --i)
        {
            var left = i * 2 + 1;
            var right = i * 2 + 2;
            result += Math.Abs(cost[left] - cost[right]);
            cost[i] += Math.Max(cost[left], cost[right]);
        }

        return result;
    }
}
