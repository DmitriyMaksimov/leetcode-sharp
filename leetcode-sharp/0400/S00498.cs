namespace leetcode_sharp;

// 498. Diagonal Traverse
// https://leetcode.com/problems/diagonal-traverse
public class S00498
{
    public int[] FindDiagonalOrder(int[][] matrix)
    {
        if (matrix.Length == 0)
        {
            return [];
        }

        var row = 0;
        var column = 0;
        var m = matrix.Length;
        var n = matrix[0].Length;
        var result = new int[m * n];

        for (var i = 0; i < result.Length; i++)
        {
            result[i] = matrix[row][column];

            if ((row + column) % 2 == 0)
            {
                if (column == n - 1)
                {
                    row++;
                }
                else if (row == 0)
                {
                    column++;
                }
                else
                {
                    row--;
                    column++;
                }
            }
            else
            {
                if (row == m - 1)
                {
                    column++;
                }
                else if (column == 0)
                {
                    row++;
                }
                else
                {
                    row++;
                    column--;
                }
            }
        }

        return result;
    }
}
