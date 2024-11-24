namespace leetcode_sharp;

// 1975. Maximum Matrix Sum
// https://leetcode.com/problems/maximum-matrix-sum
public class S01975
{
    public long MaxMatrixSum(int[][] matrix)
    {
        var sum = 0L;
        var negativeCount = 0;
        var minAbsValue = int.MaxValue;

        for (var i = 0; i < matrix.Length; i++)
        {
            for (var j = 0; j < matrix[0].Length; j++)
            {
                var value = matrix[i][j];
                if (value < 0)
                {
                    negativeCount++;
                }

                sum += Math.Abs(value);
                minAbsValue = Math.Min(minAbsValue, Math.Abs(value));
            }
        }

        return negativeCount % 2 == 0 ? sum : sum - 2L * minAbsValue;
    }
}
