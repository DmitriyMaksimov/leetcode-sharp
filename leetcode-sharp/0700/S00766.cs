namespace leetcode_sharp;

// 766. Toeplitz Matrix
// https://leetcode.com/problems/toeplitz-matrix/
public class S00766
{
    public bool IsToeplitzMatrix(int[][] matrix)
    {
        var n = matrix.Length;
        var m = matrix[0].Length;
        
        for (var i = 0; i < n; i++)
        {
            for (var j = 0; j < m; j++)
            {
                if (j - i >= 0 && matrix[i][j] != matrix[0][j - i] || i - j >= 0 && matrix[i][j] != matrix[i - j][0])
                    return false;
            }
        }
        
        return true;
    }
}