namespace leetcode_sharp;

// 2661. First Completely Painted Row or Column
// https://leetcode.com/problems/first-completely-painted-row-or-column
public class S02661
{
    public int FirstCompleteIndex(int[] arr, int[][] mat)
    {
        var numRows = mat.Length;
        var numCols = mat[0].Length;
        var rowCount = new int[numRows];
        var colCount = new int[numCols];
        var numToPos = new Dictionary<int, (int row, int col)>();

        for (var row = 0; row < numRows; row++)
        {
            for (var col = 0; col < numCols; col++)
            {
                var value = mat[row][col];
                numToPos[value] = (row, col);
            }
        }

        for (var i = 0; i < arr.Length; i++)
        {
            var num = arr[i];
            var pos = numToPos[num];
            var row = pos.row;
            var col = pos.col;

            rowCount[row]++;
            colCount[col]++;

            if (rowCount[row] == numCols || colCount[col] == numRows)
            {
                return i;
            }
        }

        return -1;
    }
}
