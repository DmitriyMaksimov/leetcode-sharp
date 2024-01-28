namespace leetcode_sharp;

// 1074. Number of Submatrices That Sum to Target
// https://leetcode.com/problems/number-of-submatrices-that-sum-to-target
public class S01074
{
    public int NumSubmatrixSumTarget(int[][] matrix, int target)
    {
        var result = 0;
        var m = matrix.Length;
        var n = matrix[0].Length;

        for (var i = 0; i < m; i++)
        {
            for (var j = 1; j < n; j++)
            {
                matrix[i][j] += matrix[i][j - 1];
            }
        }


        for (var i = 0; i < n; i++)
        {
            for (var j = i; j < n; j++)
            {
                var counter = new Dictionary<int, int> {[0] = 1};
                var current = 0;

                for (var k = 0; k < m; k++)
                {
                    current += matrix[k][j] - (i > 0 ? matrix[k][i - 1] : 0);
                    result += counter.GetValueOrDefault(current - target);
                    counter[current] = counter.GetValueOrDefault(current) + 1;
                }
            }
        }

        return result;
    }
}