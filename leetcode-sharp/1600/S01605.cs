namespace leetcode_sharp;

// 1605. Find Valid Matrix Given Row and Column Sums
// https://leetcode.com/problems/find-valid-matrix-given-row-and-column-sums
public class S01605
{
    public int[][] RestoreMatrix(int[] rowSum, int[] colSum)
    {
        var m = rowSum.Length;
        var n = colSum.Length;
        var matrix = new int[m][];

        for (var i = 0; i < m; ++i)
        {
            matrix[i] = new int[n];
            for (var j = 0; j < n; ++j)
            {
                matrix[i][j] = Math.Min(rowSum[i], colSum[j]);
                rowSum[i] -= matrix[i][j];
                colSum[j] -= matrix[i][j];
            }
        }

        return matrix;
    }
}