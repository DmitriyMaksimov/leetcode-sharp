namespace leetcode_sharp;

// 980. Unique Paths III
// https://leetcode.com/problems/unique-paths-iii/
public class S00980
{
    private int _result;
    private int _countOfEmptyCells = 1;

    public int UniquePathsIII(int[][] grid)
    {
        var startX = 0;
        var startY = 0;
        
        for (var i = 0; i < grid[0].Length; i++)
        {
            for (var j = 0; j < grid.Length; j++)
            {
                switch (grid[j][i])
                {
                    case 1:
                        startX = i;
                        startY = j;
                        break;
                    case 0:
                        _countOfEmptyCells++;
                        break;
                }
            }
        }

        dfs(grid, startX, startY, 0);

        return _result;
    }

    private void dfs(int[][] grid, int x, int y, int count)
    {
        if (x < 0 || x >= grid[0].Length || y < 0 || y >= grid.Length || grid[y][x] == -1) return;

        if (grid[y][x] == 2)
        {
            if (_countOfEmptyCells == count) _result++;
            return;
        }

        grid[y][x] = -1;

        ++count;
        dfs(grid, x + 1, y, count);
        dfs(grid, x - 1, y, count);
        dfs(grid, x, y + 1, count);
        dfs(grid, x, y - 1, count);

        grid[y][x] = 0;
    }
}