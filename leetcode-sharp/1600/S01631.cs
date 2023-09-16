namespace leetcode_sharp;

// 1631. Path With Minimum Effort
// https://leetcode.com/problems/path-with-minimum-effort/
public class S01631
{
    public int MinimumEffortPath(int[][] heights)
    {
        var rows = heights.Length;
        var cols = heights[0].Length;
        var minHeap = new SortedSet<(int effort, int x, int y)> {(0, 0, 0)};
        var dist = createDist(rows, cols);
        var directions = new[] {new[] {0, 1}, new[] {0, -1}, new[] {1, 0}, new[] {-1, 0}};

        while (minHeap.Count > 0)
        {
            var (effort, x, y) = minHeap.Min;

            minHeap.Remove(minHeap.Min);

            if (effort > dist[x, y]) continue;

            if (x == rows - 1 && y == cols - 1) return effort;

            foreach (var dir in directions)
            {
                int nx = x + dir[0], ny = y + dir[1];

                if (nx < 0 || nx >= rows || ny < 0 || ny >= cols) continue;
                
                var newEffort = Math.Max(effort, Math.Abs(heights[x][y] - heights[nx][ny]));

                if (newEffort >= dist[nx, ny]) continue;
                    
                dist[nx, ny] = newEffort;

                minHeap.Add((newEffort, nx, ny));
            }
        }

        return -1;
    }

    private static int[,] createDist(int rows, int cols)
    {
        var dist = new int[rows, cols];

        for (var i = 0; i < rows; i++)
        {
            for (var j = 0; j < cols; j++)
            {
                dist[i, j] = int.MaxValue;
            }
        }

        dist[0, 0] = 0;

        return dist;
    }
}