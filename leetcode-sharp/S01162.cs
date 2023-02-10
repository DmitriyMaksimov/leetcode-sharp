namespace leetcode_sharp;

public class S01162
{
    private readonly HashSet<(int, int)> _visited = new();
    private readonly int[] _directions = {0, -1, 0, 1, 0};

    public int MaxDistance(int[][] grid)
    {
        const int land = 1;
        var columns = grid.Length;
        var rows = grid[0].Length;
        var queue = new Queue<(int row, int col)>();

        for (var col = 0; col < columns; ++col)
        {
            for (var row = 0; row < rows; ++row)
            {
                if (grid[col][row] == land)
                {
                    queue.Enqueue((row, col));
                    _visited.Add((row, col));
                }
            }
        }

        var distance = -1;

        var tempQueue = new Queue<(int row, int col)>();

        while (queue.Any())
        {
            var (row, col) = queue.Dequeue();

            for (var d = 0; d < 4; ++d)
            {
                var newRow = row + _directions[d];
                var newCol = col + _directions[d + 1];

                if (!_visited.Contains((newRow, newCol)) && newRow >= 0 && newRow < rows && newCol >= 0 && newCol < columns)
                {
                    _visited.Add((newRow, newCol));
                    tempQueue.Enqueue((newRow, newCol));
                }
            }

            if (queue.Any()) continue;
            
            ++distance;
            (queue, tempQueue) = (tempQueue, queue);
        }
        
        return distance == 0 ? -1 : distance;
    }
}