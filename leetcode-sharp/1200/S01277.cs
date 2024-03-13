namespace leetcode_sharp;

// 1277. Count Square Submatrices with All Ones
// https://leetcode.com/problems/count-square-submatrices-with-all-ones
public class S01277
{
    public int CountSquares(int[][] matrix)
    {
        var result = 0;
        
        for (var i = 0; i < matrix.Length; ++i)
        {
            for (var j = 0; j < matrix[0].Length; ++j)
            {
                if (matrix[i][j] > 0 && i > 0 && j > 0)
                {
                    matrix[i][j] = Math.Min(matrix[i - 1][j - 1], Math.Min(matrix[i - 1][j], matrix[i][j - 1])) + 1;
                }

                result += matrix[i][j];
            }
        }

        return result;
    }
}