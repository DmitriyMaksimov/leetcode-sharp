namespace leetcode_sharp;

// 1937. Maximum Number of Points with Cost
// https://leetcode.com/problems/maximum-number-of-points-with-cost
public class S01937
{
    public long MaxPoints(int[][] points)
    {
        var m = points.Length;
        var n = points[0].Length;
        var prev = new long[n];

        for (var i = 0; i < n; ++i)
        {
            prev[i] = points[0][i];
        }

        for (var i = 0; i < m - 1; ++i)
        {
            var left = new long[n];
            var right = new long[n];
            var current = new long[n];

            left[0] = prev[0];
            right[n - 1] = prev[n - 1];

            for (var j = 1; j < n; ++j)
            {
                left[j] = Math.Max(left[j - 1] - 1, prev[j]);
            }

            for (var j = n - 2; j >= 0; --j)
            {
                right[j] = Math.Max(right[j + 1] - 1, prev[j]);
            }

            for (var j = 0; j < n; ++j)
            {
                current[j] = points[i + 1][j] + Math.Max(left[j], right[j]);
            }

            prev = current;
        }

        return prev.Max();
    }
}
