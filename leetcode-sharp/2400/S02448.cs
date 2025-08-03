namespace leetcode_sharp;

// 2448. Minimum Cost to Make Array Equal
// https://leetcode.com/problems/minimum-cost-to-make-array-equal/
public class S02448
{
    public long MinCost(int[] nums, int[] cost)
    {
        var n = nums.Length;

        var numsAndCost = new int[n][];
        for (var i = 0; i < n; ++i)
        {
            numsAndCost[i] = [nums[i], cost[i]];
        }

        Array.Sort(numsAndCost, (a, b) => a[0] - b[0]);

        // Get the prefix sum array of the costs
        var prefixSumCost = new long[n];
        prefixSumCost[0] = numsAndCost[0][1];

        for (var i = 1; i < n; ++i)
        {
            prefixSumCost[i] = prefixSumCost[i - 1] + numsAndCost[i][1];
        }

        var totalCost = 0L;
        for (var i = 1; i < n; ++i)
        {
            totalCost += (long)numsAndCost[i][1] * (numsAndCost[i][0] - numsAndCost[0][0]);
        }

        var result = totalCost;

        for (var i = 1; i < n; ++i)
        {
            var gap = numsAndCost[i][0] - numsAndCost[i - 1][0];
            totalCost += prefixSumCost[i - 1] * gap;
            totalCost -= (prefixSumCost[n - 1] - prefixSumCost[i - 1]) * gap;
            result = Math.Min(result, totalCost);
        }

        return result;
    }
}