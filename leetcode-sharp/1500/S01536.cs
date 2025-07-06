namespace leetcode_sharp;

// 1536. Minimum Swaps to Arrange a Binary Grid
// https://leetcode.com/problems/minimum-swaps-to-arrange-a-binary-grid 
public class S01536
{
    public int MinSwaps(int[][] grid)
    {
        var n = grid.Length;
        var swapCount = 0;

        var trailingZerosPerRow = new List<int>();
        for (var row = 0; row < n; row++)
        {
            var trailingZeros = 0;
            for (var col = n - 1; col >= 0 && grid[row][col] == 0; col--)
            {
                trailingZeros++;
            }

            trailingZerosPerRow.Add(trailingZeros);
        }

        for (int currentRow = 0, requiredTrailingZeros = n - 1; currentRow < n; currentRow++, requiredTrailingZeros--)
        {
            var candidateRow = currentRow;

            while (candidateRow < n && trailingZerosPerRow[candidateRow] < requiredTrailingZeros)
            {
                candidateRow++;
            }

            if (candidateRow == n)
            {
                return -1;
            }

            var trailingZerosToMove = trailingZerosPerRow[candidateRow];
            trailingZerosPerRow.RemoveAt(candidateRow);
            trailingZerosPerRow.Insert(currentRow, trailingZerosToMove);
            swapCount += candidateRow - currentRow;
        }

        return swapCount;
    }
}