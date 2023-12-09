namespace leetcode_sharp;

// 807. Max Increase to Keep City Skyline
// https://leetcode.com/problems/max-increase-to-keep-city-skyline
public class S00807
{
    public int MaxIncreaseKeepingSkyline(int[][] grid)
    {
        var n = grid.Length;
        var rowMax = new int[n];
        var colMax = new int[n];

        for (var i = 0; i < n; i++)
        {
            for (var j = 0; j < n; j++)
            {
                rowMax[i] = Math.Max(rowMax[i], grid[i][j]);
            }
        }

        for (var j = 0; j < n; j++)
        {
            for (var i = 0; i < n; i++)
            {
                colMax[j] = Math.Max(colMax[j], grid[i][j]);
            }
        }

        var result = 0;

        for (var i = 0; i < n; i++)
        {
            for (var j = 0; j < n; j++)
            {
                var maxAllowedHeight = Math.Min(rowMax[i], colMax[j]);
                result += maxAllowedHeight - grid[i][j];
            }
        }

        return result;
    }
}