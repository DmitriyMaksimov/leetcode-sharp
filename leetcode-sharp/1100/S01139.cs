namespace leetcode_sharp;

// 1139. Largest 1-Bordered Square
// https://leetcode.com/problems/largest-1-bordered-square
public class S01139
{
    public int Largest1BorderedSquare(int[][] grid)
    {
        if (grid.Length == 0)
        {
            return 0;
        }

        var m = grid.Length;
        var n = grid[0].Length;
        var dp = new int[m + 1, n + 1, 2];
        var max = 0;

        for (var i = 0; i < m; i++)
        {
            for (var j = 0; j < n; j++)
            {
                if (grid[i][j] == 1)
                {
                    dp[i + 1, j + 1, 0] = dp[i, j + 1, 0] + 1;
                    dp[i + 1, j + 1, 1] = dp[i + 1, j, 1] + 1;

                    var len = Math.Min(dp[i + 1, j + 1, 0], dp[i + 1, j + 1, 1]);
                    for (var k = len; k > max; k--)
                    {
                        if (Math.Min(dp[i + 1 - k + 1, j + 1, 1], dp[i + 1, j + 1 - k + 1, 0]) >= k)
                        {
                            max = Math.Max(max, k);
                        }
                    }
                }
                else
                {
                    dp[i + 1, j + 1, 0] = 0;
                    dp[i + 1, j + 1, 1] = 0;
                }
            }
        }

        return max * max;
    }
}
