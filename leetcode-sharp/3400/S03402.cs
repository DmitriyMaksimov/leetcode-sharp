namespace leetcode_sharp;

// 3402. Minimum Operations to Make Columns Strictly Increasing
// https://leetcode.com/problems/minimum-operations-to-make-columns-strictly-increasing
public class S03402
{
    public int MinimumOperations(int[][] grid)
    {
        var result = 0;

        for (var i = 0; i < grid[0].Length; i++)
        {
            var currentMax = grid[0][i];

            for (var j = 1; j < grid.Length; j++)
            {
                if (grid[j][i] <= currentMax)
                {
                    result += currentMax - grid[j][i] + 1;
                    ++currentMax;
                }
                else
                {
                    currentMax = grid[j][i];
                }
            }
        }

        return result;
    }
}
