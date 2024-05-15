namespace leetcode_sharp;

// 2812. Find the Safest Path in a Grid
// https://leetcode.com/problems/find-the-safest-path-in-a-grid
public class S02812
{
    private readonly int[] _directions = [0, 1, 0, -1, 0];

    public int MaximumSafenessFactor(IList<IList<int>> grid)
    {
        var n = grid.Count;
        var mat = new int[n, n];
        var queue = new Queue<(int, int)>();

        for (var i = 0; i < n; i++)
        {
            for (var j = 0; j < n; j++)
            {
                if (grid[i][j] == 1)
                {
                    queue.Enqueue((i, j));
                    mat[i, j] = 0;
                }
                else
                {
                    mat[i, j] = -1;
                }
            }
        }

        while (queue.Count > 0)
        {
            var size = queue.Count;

            while (size-- > 0)
            {
                var (row, col) = queue.Dequeue();

                for (var i = 0; i < _directions.Length - 1; i++)
                {
                    var di = row + _directions[i];
                    var dj = col + _directions[i + 1];
                    var val = mat[row, col];

                    if (!IsValidCell(mat, di, dj) || mat[di, dj] != -1)
                    {
                        continue;
                    }

                    mat[di, dj] = val + 1;
                    queue.Enqueue((di, dj));
                }
            }
        }

        var start = 0;
        var end = 0;
        var result = -1;

        for (var i = 0; i < n; i++)
        {
            for (var j = 0; j < n; j++)
            {
                end = Math.Max(end, mat[i, j]);
            }
        }

        while (start <= end)
        {
            var mid = start + (end - start) / 2;
            if (IsValidSafeness(mat, mid))
            {
                result = mid;
                start = mid + 1;
            }
            else
            {
                end = mid - 1;
            }
        }

        return result;
    }

    private bool IsValidSafeness(int[,] grid, int minSafeness)
    {
        var n = grid.GetLength(0);

        if (grid[0, 0] < minSafeness || grid[n - 1, n - 1] < minSafeness)
        {
            return false;
        }

        var traversalQueue = new Queue<int[]>();
        traversalQueue.Enqueue([0, 0]);
        var visited = new bool[n, n];
        visited[0, 0] = true;

        while (traversalQueue.Count > 0)
        {
            var curr = traversalQueue.Dequeue();
            if (curr[0] == n - 1 && curr[1] == n - 1)
            {
                return true;
            }

            for (var i = 0; i < _directions.Length - 1; i++)
            {
                var di = curr[0] + _directions[i];
                var dj = curr[1] + _directions[i + 1];

                if (IsValidCell(grid, di, dj) && !visited[di, dj] && grid[di, dj] >= minSafeness)
                {
                    visited[di, dj] = true;
                    traversalQueue.Enqueue([di, dj]);
                }
            }
        }

        return false;
    }

    private static bool IsValidCell(int[,] mat, int i, int j)
    {
        var n = mat.GetLength(0);
        return i >= 0 && j >= 0 && i < n && j < n;
    }
}