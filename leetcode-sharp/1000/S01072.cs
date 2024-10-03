namespace leetcode_sharp;

// 1072. Flip Columns For Maximum Number of Equal Rows
// https://leetcode.com/problems/flip-columns-for-maximum-number-of-equal-rows
public class S01072
{
    public int MaxEqualRowsAfterFlips(int[][] matrix)
    {
        var result = 0;
        var m = matrix.Length;
        var n = matrix[0].Length;

        for (var i = 0; i < m; i++)
        {
            var count = 0;
            var flip = matrix[i].Select(x => 1 - x).ToArray();

            for (var k = i; k < m; k++)
            {
                if (matrix[k].SequenceEqual(matrix[i]) || matrix[k].SequenceEqual(flip))
                {
                    count++;
                }
            }

            result = Math.Max(result, count);
        }

        return result;
    }
}
