namespace leetcode_sharp;

// 1314. Matrix Block Sum
// https://leetcode.com/problems/matrix-block-sum/
public class S01314
{
    public int[][] MatrixBlockSum(int[][] mat, int k)
    {
        var m = mat.Length;
        var n = mat[0].Length;
        var sum = new int[m + 1, n + 1]; // sum[i][j] is sum of all elements from rectangle (0,0,i,j) as left, top, right, bottom corresponding

        for (var r = 1; r <= m; r++)
        {
            for (var c = 1; c <= n; c++)
            {
                sum[r, c] = mat[r - 1][c - 1] + sum[r - 1, c] + sum[r, c - 1] - sum[r - 1, c - 1];
            }
        }

        var result = new int[m][];
        for (var i = 0; i < m; i++)
        {
            result[i] = new int[n];
        }
        
        for (var r = 0; r < m; r++)
        {
            for (var c = 0; c < n; c++)
            {
                var r1 = Math.Max(0, r - k) + 1;
                var c1 = Math.Max(0, c - k) + 1;
                var r2 = Math.Min(m - 1, r + k) + 1;
                var c2 = Math.Min(n - 1, c + k) + 1;
                result[r][c] = sum[r2, c2] - sum[r2, c1 - 1] - sum[r1 - 1, c2] + sum[r1 - 1, c1 - 1];
            }
        }

        return result;
    }
}