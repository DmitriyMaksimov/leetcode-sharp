namespace leetcode_sharp;

// 1380. Lucky Numbers in a Matrix
// https://leetcode.com/problems/lucky-numbers-in-a-matrix/
public class S01380
{
    public IList<int> LuckyNumbers(int[][] matrix)
    {
        var rows = matrix.Length;
        var cols = matrix[0].Length;

        var minInRow = new int[rows];
        var maxInCol = new int[cols];
        Array.Fill(minInRow, int.MaxValue);
        Array.Fill(maxInCol, int.MinValue);

        for (var i = 0; i < rows; i++)
        {
            for (var j = 0; j < cols; j++)
            {
                minInRow[i] = Math.Min(minInRow[i], matrix[i][j]);
                maxInCol[j] = Math.Max(maxInCol[j], matrix[i][j]);
            }
        }

        var result = new List<int>();

        for (var i = 0; i < rows; i++)
        {
            for (var j = 0; j < cols; j++)
            {
                if (matrix[i][j] == minInRow[i] && matrix[i][j] == maxInCol[j])
                {
                    result.Add(matrix[i][j]);
                }
            }
        }

        return result;
    }
}