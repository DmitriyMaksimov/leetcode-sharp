namespace leetcode_sharp;

// 1091. Shortest Path in Binary Matrix
// https://leetcode.com/problems/shortest-path-in-binary-matrix/
public class S01091
{
    private readonly int[] _directions = [-1, 0, 1];

    public int ShortestPathBinaryMatrix(int[][] grid)
    {
        var n = grid.Length;

        if (grid[0][0] == 1 || grid[n - 1][n - 1] == 1)
        {
            return -1;
        }

        var queue = new Queue<(int x, int y, int steps)>();
        queue.Enqueue((0, 0, 1));
        grid[0][0] = 1;

        while (queue.Any())
        {
            var (x, y, steps) = queue.Dequeue();

            if (x == n - 1 && y == n - 1)
            {
                return steps;
            }

            foreach (var dx in _directions)
            {
                foreach (var dy in _directions)
                {
                    var nx = x + dx;
                    var ny = y + dy;
                    if (nx < 0 || nx >= n || ny < 0 || ny >= n || grid[nx][ny] != 0) continue;

                    queue.Enqueue((nx, ny, steps + 1));
                    grid[nx][ny] = 1;
                }
            }
        }

        return -1;
    }
}