namespace leetcode_sharp;

// 2906. Construct Product Matrix
// https://leetcode.com/problems/construct-product-matrix
public class S02906
{
    private const int Mod = 12345;

    public int[][] ConstructProductMatrix(int[][] grid)
    {
        var n = grid.Length;
        var m = grid[0].Length;

        var result = new int[n][];
        for (var i = 0; i < n; i++)
        {
            result[i] = new int[m];
        }

        var suffix = 1;
        for (var i = n - 1; i >= 0; i--)
        {
            for (var j = m - 1; j >= 0; j--)
            {
                result[i][j] = suffix;
                suffix = (int)((long)suffix * grid[i][j] % Mod);
            }
        }

        var prefix = 1;
        for (var i = 0; i < n; i++)
        {
            for (var j = 0; j < m; j++)
            {
                result[i][j] = (int)((long)result[i][j] * prefix % Mod);
                prefix = (int)((long)prefix * grid[i][j] % Mod);
            }
        }

        return result;
    }
}