namespace leetcode_sharp;

// 1034. Coloring A Border
// https://leetcode.com/problems/coloring-a-border
public class S01034
{
    private bool[,] _visited = null!;

    public int[][] ColorBorder(int[][] grid, int row, int col, int color)
    {
        var originalColor = grid[row][col];
        _visited = new bool[grid.Length, grid[0].Length];

        Dfs(grid, row, col, originalColor);

        for (var i = 0; i < grid.Length; i++)
        {
            for (var j = 0; j < grid[i].Length; j++)
            {
                if (!_visited[i, j])
                {
                    continue;
                }

                var isBorder = false;

                if (i == 0 || i == grid.Length - 1 || j == 0 || j == grid[i].Length - 1)
                {
                    isBorder = true;
                }
                else
                {
                    if (!_visited[i - 1, j] || !_visited[i + 1, j] || !_visited[i, j - 1] || !_visited[i, j + 1])
                    {
                        isBorder = true;
                    }
                }

                if (isBorder)
                {
                    grid[i][j] = color;
                }
            }
        }

        return grid;
    }

    private void Dfs(int[][] grid, int row, int col, int originalColor)
    {
        if (row < 0 || row >= grid.Length || col < 0 || col >= grid[0].Length || grid[row][col] != originalColor || _visited[row, col])
        {
            return;
        }

        _visited[row, col] = true;

        Dfs(grid, row - 1, col, originalColor);
        Dfs(grid, row + 1, col, originalColor);
        Dfs(grid, row, col - 1, originalColor);
        Dfs(grid, row, col + 1, originalColor);
    }
}
