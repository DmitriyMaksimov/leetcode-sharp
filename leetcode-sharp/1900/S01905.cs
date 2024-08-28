namespace leetcode_sharp;

// 1905. Count Sub Islands
// https://leetcode.com/problems/count-sub-islands
public class S01905
{
    public int CountSubIslands(int[][] grid1, int[][] grid2)
    {
        var result = 0;

        for (var i = 0; i < grid2.Length; i++)
        {
            for (var j = 0; j < grid2[0].Length; j++)
            {
                if (grid2[i][j] == 1 && IsSubIsland(grid1, grid2, i, j))
                {
                    result++;
                }
            }
        }

        return result;
    }

    private static bool IsSubIsland(int[][] grid1, int[][] grid2, int i, int j)
    {
        var result = true;

        if (i < 0 || i >= grid2.Length || j < 0 || j >= grid2[0].Length || grid2[i][j] != 1)
        {
            return result;
        }

        if (grid2[i][j] != grid1[i][j])
        {
            result = false;
        }

        grid2[i][j] = -1;

        var left = IsSubIsland(grid1, grid2, i, j - 1);
        var right = IsSubIsland(grid1, grid2, i, j + 1);
        var top = IsSubIsland(grid1, grid2, i - 1, j);
        var bottom = IsSubIsland(grid1, grid2, i + 1, j);

        return left && right && top && bottom && result;
    }
}
