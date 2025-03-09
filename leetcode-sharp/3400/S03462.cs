namespace leetcode_sharp;

// 3462. Maximum Sum With at Most K Elements
// https://leetcode.com/problems/maximum-sum-with-at-most-k-elements
public class S03462
{
    public long MaxSum(int[][] grid, int[] limits, int k)
    {
        var topElements = new List<long>();

        for (var i = 0; i < grid.Length; i++)
        {
            topElements.AddRange(grid[i].Select(x => (long)x).OrderDescending().Take(Math.Min(k, limits[i])));
        }

        return topElements.OrderDescending().Take(k).Sum();
    }
}
