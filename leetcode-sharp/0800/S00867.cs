namespace leetcode_sharp;

// 867. Transpose Matrix
// https://leetcode.com/problems/transpose-matrix/
public class S00867
{
    public int[][] Transpose(int[][] matrix)
    {
        var n = matrix.Length;
        var m = matrix[0].Length;
        var result = new int[m][];

        for (var i = 0; i < m; i++)
        {
            result[i] = new int[n];

            for (var j = 0; j < n; j++)
            {
                result[i][j] = matrix[j][i];
            }
        }

        return result;
    }
}