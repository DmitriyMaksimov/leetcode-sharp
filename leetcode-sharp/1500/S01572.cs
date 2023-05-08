namespace leetcode_sharp;

// 1572. Matrix Diagonal Sum
// https://leetcode.com/problems/matrix-diagonal-sum/
public class S01572
{
    public int DiagonalSum(int[][] mat)
    {
        var n = mat.Length;

        var sum = 0;
        for (var i = 0; i < n; i++)
        {
            sum += mat[i][i];
            sum += mat[n - i - 1][i];
        }

        if (n % 2 == 1)
        {
            var mid = n / 2;
            sum -= mat[mid][mid];
        }
        
        return sum;
    }
}