namespace leetcode_sharp;

// 861. Score After Flipping Matrix
// https://leetcode.com/problems/score-after-flipping-matrix
public class S00861
{
    public int MatrixScore(int[][] grid)
    {
        var m = grid.Length;
        var n = grid[0].Length;
        var result = (1 << (n - 1)) * m;

        for (var j = 1; j < n; j++)
        {
            var cur = 0;
            for (var i = 0; i < m; i++)
            {
                cur += grid[i][j] == grid[i][0] ? 1 : 0;
            }

            result += Math.Max(cur, m - cur) * (1 << (n - j - 1));
        }

        return result;
    }
}