namespace leetcode_sharp;

// 48. Rotate Image
// https://leetcode.com/problems/rotate-image/
public class S00048
{
    public void Rotate(int[][] matrix)
    {
        for (var i = 0; i < matrix.Length; ++i)
        {
            for (var j = i + 1; j < matrix[i].Length; ++j)
            {
                (matrix[i][j], matrix[j][i]) = (matrix[j][i], matrix[i][j]);
            }
            
            matrix[i] = matrix[i].Reverse().ToArray();
        }
    }
}