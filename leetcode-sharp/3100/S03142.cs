namespace leetcode_sharp;

// 3142. Check if Grid Satisfies Conditions
// https://leetcode.com/problems/check-if-grid-satisfies-conditions
public class S03142
{
    public bool SatisfiesConditions(int[][] grid)
    {
        for (var i = 0; i < grid.Length - 1; i++)
        {
            for (var j = 0; j < grid[0].Length; j++)
            {
                if (grid[i][j] != grid[i + 1][j])
                {
                    return false;
                }
            }
        }

        foreach (var c in grid)
        {
            for (var j = 0; j < grid[0].Length - 1; j++)
            {
                if (c[j] == c[j + 1])
                {
                    return false;
                }
            }
        }

        return true;
    }
}
