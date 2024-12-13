namespace leetcode_sharp;

// 1292. Maximum Side Length of a Square with Sum Less than or Equal to Threshold
// https://leetcode.com/problems/maximum-side-length-of-a-square-with-sum-less-than-or-equal-to-threshold
public class S01292
{
    public int MaxSideLength(int[][] mat, int threshold)
    {
        var n = mat.Length;
        var m = mat[0].Length;
        var sums = new int[n + 1, m + 1];
        var result = 0;

        for (var i = 0; i < n; i++)
        {
            for (var j = 0; j < m; j++)
            {
                sums[i + 1, j + 1] = sums[i + 1, j] + sums[i, j + 1] - sums[i, j] + mat[i][j];
                if (i - result >= 0 && j - result >= 0 && sums[i + 1, j + 1] - sums[i - result, j + 1] - sums[i + 1, j - result] + sums[i - result, j - result] <= threshold)
                {
                    ++result;
                }
            }
        }

        return result;
    }
}
