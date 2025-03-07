namespace leetcode_sharp;

// 1914. Cyclically Rotating a Grid
// https://leetcode.com/problems/cyclically-rotating-a-grid
public class S01914
{
    public int[][] RotateGrid(int[][] grid, int k)
    {
        var m = grid.Length;
        var n = grid[0].Length;
        var layers = Math.Min(m, n) / 2;

        for (var layer = 0; layer < layers; ++layer)
        {
            var v = new List<int>();

            for (var i = layer; i < n - layer - 1; ++i)
            {
                v.Add(grid[layer][i]);
            }

            for (var i = layer; i < m - layer - 1; ++i)
            {
                v.Add(grid[i][n - layer - 1]);
            }

            for (var i = n - layer - 1; i > layer; --i)
            {
                v.Add(grid[m - layer - 1][i]);
            }

            for (var i = m - layer - 1; i > layer; --i)
            {
                v.Add(grid[i][layer]);
            }

            var start = k % v.Count;

            for (var i = layer; i < n - layer - 1; ++i)
            {
                grid[layer][i] = v[start++ % v.Count];
            }

            for (var i = layer; i < m - layer - 1; ++i)
            {
                grid[i][n - layer - 1] = v[start++ % v.Count];
            }

            for (var i = n - layer - 1; i > layer; --i)
            {
                grid[m - layer - 1][i] = v[start++ % v.Count];
            }

            for (var i = m - layer - 1; i > layer; --i)
            {
                grid[i][layer] = v[start++ % v.Count];
            }
        }

        return grid;
    }
}
