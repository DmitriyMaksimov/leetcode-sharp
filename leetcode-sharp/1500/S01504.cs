namespace leetcode_sharp;

// 1504. Count Submatrices With All Ones
// https://leetcode.com/problems/count-submatrices-with-all-ones
public class S01504
{
    public int NumSubmat(int[][] mat)
    {
        var m = mat.Length;
        var n = mat[0].Length;
        var height = new int[n];
        var result = 0;

        for (var i = 0; i < m; i++)
        {
            for (var j = 0; j < n; j++)
            {
                height[j] = mat[i][j] == 0 ? 0 : height[j] + 1;

                var min = height[j];

                for (var k = j; k >= 0 && min > 0; k--)
                {
                    min = Math.Min(min, height[k]);
                    result += min;
                }
            }
        }

        return result;
    }
}
