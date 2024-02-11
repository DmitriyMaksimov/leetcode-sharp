namespace leetcode_sharp;

// 100230. Modify the Matrix
public class S100230
{
    public int[][] ModifiedMatrix(int[][] matrix)
    {
        var rows = matrix.Length;
        var cols = matrix[0].Length;
        var max = new int[cols];
        
        for (var col = 0; col < cols; col++)
        {
            for (var row = 0; row < rows; row++)
            {
                max[col] = Math.Max(max[col], matrix[row][col]);
            }
        }

        for (var col = 0; col < cols; col++)
        {
            for (var row = 0; row < rows; row++)
            {
                if (matrix[row][col] == -1)
                {
                    matrix[row][col] = max[col];
                }
            }
        }

        return matrix;
    }
}