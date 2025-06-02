namespace leetcode_sharp;

// 3567. Minimum Absolute Difference in Sliding Submatrix
// https://leetcode.com/problems/minimum-absolute-difference-in-sliding-submatrix
public class S03567
{
    public int[][] MinAbsDiff(int[][] grid, int k)
    {
        var totalRows = grid.Length;
        var totalCols = grid[0].Length;
        var resultRows = totalRows - k + 1;
        var resultCols = totalCols - k + 1;

        var result = new int[resultRows][];
        for (var i = 0; i < resultRows; i++)
        {
            result[i] = new int[resultCols];
        }

        for (var rowStart = 0; rowStart < resultRows; rowStart++)
        {
            for (var colStart = 0; colStart < resultCols; colStart++)
            {
                var values = new List<int>(k * k);

                for (var i = rowStart; i < rowStart + k; i++)
                {
                    for (var j = colStart; j < colStart + k; j++)
                    {
                        values.Add(grid[i][j]);
                    }
                }

                values.Sort();

                var uniqueValues = new List<int>(k * k);
                uniqueValues.Add(values[0]);
                for (var i = 1; i < values.Count; i++)
                {
                    if (values[i] != values[i - 1])
                    {
                        uniqueValues.Add(values[i]);
                    }
                }

                if (uniqueValues.Count <= 1)
                {
                    result[rowStart][colStart] = 0;
                    continue;
                }

                var minDiff = int.MaxValue;
                for (var i = 1; i < uniqueValues.Count; i++)
                {
                    var diff = uniqueValues[i] - uniqueValues[i - 1];
                    if (diff < minDiff)
                    {
                        minDiff = diff;
                        if (minDiff == 0)
                        {
                            break;
                        }
                    }
                }

                result[rowStart][colStart] = minDiff;
            }
        }

        return result;
    }
}
