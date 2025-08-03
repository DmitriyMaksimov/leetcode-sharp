namespace leetcode_sharp;

// 1970. Last Day Where You Can Still Cross
// https://leetcode.com/problems/last-day-where-you-can-still-cross/
public class S01970
{
    private readonly int[] _directions = [0, -1, 0, 1, 0];

    public int LatestDayToCross(int row, int col, int[][] cells)
    {
        var left = 0;
        var right = row * col;
        var latestPossibleDay = 0;

        while (left < right - 1)
        {
            var mid = left + (right - left) / 2;
            if (isPathExists(row, col, mid, cells))
            {
                left = mid;
                latestPossibleDay = mid;
            }
            else
            {
                right = mid;
            }
        }

        return latestPossibleDay;
    }

    private bool isPathExists(int row, int col, int mid, int[][] cells)
    {
        var visited = new bool[row + 1, col + 1];

        for (var i = 0; i < mid; i++)
        {
            visited[cells[i][0], cells[i][1]] = true;
        }

        var queue = new Queue<(int row, int col)>();

        for (var i = 1; i <= col; i++)
        {
            if (visited[1, i]) continue;
            
            // Start from the top row
            queue.Enqueue((1, i));
            visited[1, i] = true;
        }

        while (queue.Any())
        {
            var (currentRow, currentCol) = queue.Dequeue();

            for (var i = 0; i < _directions.Length - 1; i++)
            {
                var nextRow = currentRow + _directions[i];
                var nextCol = currentCol + _directions[i + 1];

                if (nextRow <= 0 || nextCol <= 0 || nextRow > row || nextCol > col || visited[nextRow, nextCol]) continue;
                
                visited[nextRow, nextCol] = true;

                if (nextRow == row)
                {
                    return true;
                }

                queue.Enqueue((nextRow, nextCol));
            }
        }

        return false;
    }
}