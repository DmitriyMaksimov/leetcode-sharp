namespace leetcode_sharp;

// 2536. Increment Submatrices by One
// https://leetcode.com/problems/increment-submatrices-by-one
public class S02536
{
    public int[][] RangeAddQueries(int n, int[][] queries)
    {
        var matrix = new int[n][];

        for (var i = 0; i < n; i++)
        {
            matrix[i] = new int[n];
        }

        foreach (var q in queries)
        {
            int r1 = q[0], c1 = q[1], r2 = q[2], c2 = q[3];

            matrix[r1][c1] += 1;
            if (r2 + 1 < n && c2 + 1 < n)
            {
                matrix[r2 + 1][c2 + 1] += 1;
            }

            if (r2 + 1 < n)
            {
                matrix[r2 + 1][c1] -= 1;
            }

            if (c2 + 1 < n)
            {
                matrix[r1][c2 + 1] -= 1;
            }
        }

        for (var i = 0; i < n; i++)
        {
            for (var j = 1; j < n; j++)
            {
                matrix[i][j] += matrix[i][j - 1];
            }
        }

        for (var i = 1; i < n; i++)
        {
            for (var j = 0; j < n; j++)
            {
                matrix[i][j] += matrix[i - 1][j];
            }
        }

        return matrix;
    }
}
