namespace leetcode_sharp;

// 3239. Minimum Number of Flips to Make Binary Grid Palindromic I
// https://leetcode.com/problems/minimum-number-of-flips-to-make-binary-grid-palindromic-i
public class S03239
{
    public int MinFlips(int[][] grid)
    {
        var m = grid.Length;
        var n = grid[0].Length;
        var colFlips = 0;
        var rowFlips = 0;

        for (var row = 0; row < n; row++)
        {
            for (var col = 0; col < m / 2; col++)
            {
                if (grid[col][row] != grid[^(col + 1)][row])
                {
                    ++colFlips;
                }
            }
        }

        for (var row = 0; row < n / 2; row++)
        {
            for (var col = 0; col < m; col++)
            {
                if (grid[col][row] != grid[col][^(row + 1)])
                {
                    ++rowFlips;
                }
            }
        }

        return Math.Min(colFlips, rowFlips);
    }
}
