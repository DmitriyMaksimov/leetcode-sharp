namespace leetcode_sharp;

// 892. Surface Area of 3D Shapes
// https://leetcode.com/problems/surface-area-of-3d-shapes/
public class S00892
{
    public int SurfaceArea(int[][] grid)
    {
        var result = 0;
        var n = grid.Length;

        for (var i = 0; i < n; i++)
        {
            for (var j = 0; j < n; j++)
            {
                var v = grid[i][j];
                if (v <= 0) continue;
                
                result += 2;
                result += i == 0 ? v : Math.Max(0, v - grid[i - 1][j]);
                result += i == n - 1 ? v : Math.Max(0, v - grid[i + 1][j]);
                result += j == 0 ? v : Math.Max(0, v - grid[i][j - 1]);
                result += j == n - 1 ? v : Math.Max(0, v - grid[i][j + 1]);
            }
        }

        return result;
    }
}