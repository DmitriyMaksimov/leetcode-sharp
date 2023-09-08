namespace leetcode_sharp;

// 1252. Cells with Odd Values in a Matrix
// https://leetcode.com/problems/cells-with-odd-values-in-a-matrix/
public class S01252
{
    public int OddCells(int m, int n, int[][] indices)
    {
        var matrix = new int[m][];
        for (var i = 0; i < m; i++)
        {
            matrix[i] = new int[n];
        }

        foreach (var index in indices)
        {
            var row = index[0];
            var col = index[1];
            for (var i = 0; i < n; i++)
            {
                matrix[row][i]++;
            }

            for (var i = 0; i < m; i++)
            {
                matrix[i][col]++;
            }
        }

        return matrix.Sum(row => row.Count(col => col % 2 == 1));
    }
}