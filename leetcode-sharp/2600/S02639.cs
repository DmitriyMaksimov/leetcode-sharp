namespace leetcode_sharp;

// 2639. Find the Width of Columns of a Grid
// https://leetcode.com/problems/find-the-width-of-columns-of-a-grid
public class S02639
{
    public int[] FindColumnWidth(int[][] grid)
    {
        var ans = new int[grid[0].Length];
        for (var i = 0; i < grid[0].Length; ++i)
        {
            foreach (var row in grid)
            {
                ans[i] = Math.Max(ans[i], row[i].ToString().Length);
            }
        }

        return ans;
    }
}