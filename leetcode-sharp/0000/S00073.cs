namespace leetcode_sharp;

// 73. Set Matrix Zeroes
// https://leetcode.com/problems/set-matrix-zeroes/
public class S00073
{
    public void SetZeroes(int[][] matrix)
    {
        var rows = new HashSet<int>();
        var columns = new HashSet<int>();
        var m = matrix.GetLength(0);
        var n = matrix[0].Length;

        for (var i = 0; i < m; i++)
        {
            for (var j = 0; j < n; j++)
            {
                if (matrix[i][j] == 0)
                {
                    rows.Add(i);
                    columns.Add(j);
                }
            }
        }

        for (var i = 0; i < m; i++)
        {
            for (var j = 0; j < n; j++)
            {
                if (rows.Contains(i) || columns.Contains(j))
                {
                    matrix[i][j] = 0;
                }
            }
        }
    }
}