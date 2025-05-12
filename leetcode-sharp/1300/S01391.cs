namespace leetcode_sharp;

// 1391. Check if There is a Valid Path in a Grid
// https://leetcode.com/problems/check-if-there-is-a-valid-path-in-a-grid
public class S01391
{
    private static readonly int[][][] Directions =
    [
        [[0, -1], [0, 1]],
        [[-1, 0], [1, 0]],
        [[0, -1], [1, 0]],
        [[0, 1], [1, 0]],
        [[0, -1], [-1, 0]],
        [[0, 1], [-1, 0]]
    ];

    public bool HasValidPath(int[][] grid)
    {
        var m = grid.Length;
        var n = grid[0].Length;
        var visited = new bool[m, n];
        var queue = new Queue<int[]>();
        queue.Enqueue([0, 0]);
        visited[0, 0] = true;

        while (queue.Count > 0)
        {
            var current = queue.Dequeue();
            var x = current[0];
            var y = current[1];
            var num = grid[x][y] - 1;

            foreach (var dir in Directions[num])
            {
                var newX = x + dir[0];
                var newY = y + dir[1];

                if (newX < 0 || newX >= m || newY < 0 || newY >= n || visited[newX, newY])
                {
                    continue;
                }

                foreach (var backDir in Directions[grid[newX][newY] - 1])
                {
                    if (newX + backDir[0] == x && newY + backDir[1] == y)
                    {
                        visited[newX, newY] = true;
                        queue.Enqueue([newX, newY]);
                        break;
                    }
                }
            }
        }

        return visited[m - 1, n - 1];
    }
}
