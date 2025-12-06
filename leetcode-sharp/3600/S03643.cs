namespace leetcode_sharp;

// 3643. Flip Square Submatrix Vertically
// https://leetcode.com/problems/flip-square-submatrix-vertically
public class S03643
{
    public int[][] ReverseSubmatrix(int[][] grid, int x, int y, int k)
    {
        var half = k / 2;

        for (var t = 0; t < half; t++)
        {
            var r1 = x + t;
            var r2 = x + k - 1 - t;

            for (var j = y; j < y + k; j++)
            {
                (grid[r1][j], grid[r2][j]) = (grid[r2][j], grid[r1][j]);
            }
        }
        
        return grid;
    }
}