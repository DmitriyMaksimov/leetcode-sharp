namespace leetcode_sharp;

// 3148. Maximum Difference Score in a Grid
// https://leetcode.com/problems/maximum-difference-score-in-a-grid
public class S03148
{
    public int MaxScore(IList<IList<int>> grid)
    {
        var result = int.MinValue;

        for (var i = 0; i < grid.Count; ++i)
        {
            for (var j = 0; j < grid[0].Count; ++j)
            {
                if (i == 0 && j == 0)
                {
                    continue;
                }

                var mn = int.MaxValue;

                if (i != 0)
                {
                    mn = Math.Min(mn, grid[i - 1][j]);
                }

                if (j != 0)
                {
                    mn = Math.Min(mn, grid[i][j - 1]);
                }

                result = Math.Max(result, grid[i][j] - mn);
                grid[i][j] = Math.Min(grid[i][j], mn);
            }
        }

        return result;
    }
}