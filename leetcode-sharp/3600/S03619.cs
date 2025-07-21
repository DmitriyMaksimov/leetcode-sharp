namespace leetcode_sharp;

// 3619. Count Islands With Total Value Divisible by K
// https://leetcode.com/problems/count-islands-with-total-value-divisible-by-k 
public class S03619
{
    private readonly int[] _directions = [0, 1, 0, -1, 0];

    public int CountIslands(int[][] grid, int k)
    {
        var rowCount = grid.Length;
        var colCount = grid[0].Length;
        var visited = new bool[rowCount, colCount];
        var result = 0;

        for (var row = 0; row < rowCount; row++)
        {
            for (var col = 0; col < colCount; col++)
            {
                if (grid[row][col] != 0 && !visited[row, col])
                {
                    var islandSum = DepthFirstSearch(row, col, grid, visited, rowCount, colCount);
                    if (islandSum % k == 0)
                    {
                        result++;
                    }
                }
            }
        }

        return result;
    }

    private long DepthFirstSearch(int row, int col, int[][] grid, bool[,] visited, int rowCount, int colCount)
    {
        visited[row, col] = true;
        long sum = grid[row][col];

        for (var direction = 0; direction < _directions.Length - 1; direction++)
        {
            var newRow = row + _directions[direction];
            var newCol = col + _directions[direction + 1];

            if (IsInBounds(newRow, newCol, rowCount, colCount) && grid[newRow][newCol] != 0 && !visited[newRow, newCol])
            {
                sum += DepthFirstSearch(newRow, newCol, grid, visited, rowCount, colCount);
            }
        }

        return sum;
    }

    private static bool IsInBounds(int row, int col, int rowCount, int colCount)
    {
        return row >= 0 && row < rowCount && col >= 0 && col < colCount;
    }
}