namespace leetcode_sharp;

// 2482. Difference Between Ones and Zeros in Row and Column
// https://leetcode.com/problems/difference-between-ones-and-zeros-in-row-and-column
public class S02482
{
    public int[][] OnesMinusZeros(int[][] grid)
    {
        var rows = grid.Length;
        var cols = grid[0].Length;
        var rowMap = new int[rows];
        var colMap = new int[cols];

        for (var row = 0; row < rows; row++)
        {
            for (var col = 0; col < cols; col++)
            {
                if (grid[row][col] == 1)
                {
                    rowMap[row]++;
                    colMap[col]++;
                }
            }
        }

        var result = new int[grid.Length][];

        for (var row = 0; row < rows; row++)
        {
            result[row] = new int[cols];
        
            for (var col = 0; col < cols; col++)
            {
                result[row][col] = rowMap[row] + colMap[col] - (rows - rowMap[row]) - (cols - colMap[col]);
            }
        }

        return result;
    }
}