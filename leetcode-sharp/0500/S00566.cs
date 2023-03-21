namespace leetcode_sharp;

// 566. Reshape the Matrix
// https://leetcode.com/problems/reshape-the-matrix/
public class S00566
{
    public int[][] MatrixReshape(int[][] mat, int r, int c)
    {
        var m = mat.Length;
        var n = mat[0].Length;

        if (m * n != r * c)
        {
            return mat;
        }
        
        var result = new int[r][];

        for (var i = 0; i < r; i++)
        {
            result[i] = new int[c];
            for (var j = 0; j < c; j++)
            {
                var globalIndex = i * c + j;
                var row = globalIndex / n;
                var col = globalIndex % n;
                result[i][j] = mat[row][col];
            }
        }

        return result;
    }
}