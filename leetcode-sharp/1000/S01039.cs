namespace leetcode_sharp;

// 1039. Minimum Score Triangulation of Polygon
// https://leetcode.com/problems/minimum-score-triangulation-of-polygon
public class S01039
{
    public int MinScoreTriangulation(int[] values)
    {
        var n = values.Length;
        var dp = new int[50, 50];

        for (var i = n - 1; i >= 0; --i)
        {
            for (var j = i + 1; j < n; ++j)
            {
                for (var k = i + 1; k < j; ++k)
                {
                    dp[i, j] = Math.Min(dp[i, j] == 0 ? int.MaxValue : dp[i, j], dp[i, k] + values[i] * values[k] * values[j] + dp[k, j]);
                }
            }
        }

        return dp[0, n - 1];
    }
}
