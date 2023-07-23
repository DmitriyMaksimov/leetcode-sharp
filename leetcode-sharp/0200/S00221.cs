namespace leetcode_sharp;

// 221. Maximal Square
// https://leetcode.com/problems/maximal-square/
public class S00221
{
    public int MaximalSquare(char[][] matrix)
    {
        if (matrix.Length == 0) return 0;
        var m = matrix.Length;
        var n = matrix[0].Length;
        var dp = new int[m + 1, n + 1];

        var maxEdge = 0;

        for (var i = 1; i <= m; i++)
        {
            for (var j = 1; j <= n; j++)
            {
                if (matrix[i - 1][j - 1] == '1')
                {
                    dp[i, j] = Math.Min(Math.Min(dp[i - 1, j], dp[i, j - 1]), dp[i - 1, j - 1]) + 1;
                    maxEdge = Math.Max(maxEdge, dp[i, j]);
                }
            }
        }

        return maxEdge * maxEdge;
    }
}