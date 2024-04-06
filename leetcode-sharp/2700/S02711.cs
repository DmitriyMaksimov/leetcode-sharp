namespace leetcode_sharp;

// 2711. Difference of Number of Distinct Values on Diagonals
// https://leetcode.com/problems/difference-of-number-of-distinct-values-on-diagonals
public class S02711
{
    public int[][] DifferenceOfDistinctValues(int[][] grid)
    {
        var m = grid.Length;
        var n = grid[0].Length;
        var result = new List<int[]>();

        for (var i = 0; i < m; i++)
        {
            result.Add(new int[n]);
        }

        for (var j = 0; j < n; ++j)
        {
            PopulateDiagonal(0, j, m, n, result, grid);
        }

        for (var i = 1; i < m; ++i)
        {
            PopulateDiagonal(i, 0, m, n, result, grid);
        }

        return result.ToArray();
    }

    private static void PopulateDiagonal(int i, int j, int m, int n, List<int[]>? result, int[][] grid)
    {
        HashSet<int> topLeft = [];
        HashSet<int> bottomRight = [];

        for (var d = 0; i + d < m && j + d < n; ++d)
        {
            result[i + d][j + d] = topLeft.Count;
            topLeft.Add(grid[i + d][j + d]);
        }

        for (var d = Math.Min(m - i, n - j) - 1; d >= 0; --d)
        {
            result[i + d][j + d] = Math.Abs(result[i + d][j + d] - (int)bottomRight.Count);
            bottomRight.Add(grid[i + d][j + d]);
        }
    }
}