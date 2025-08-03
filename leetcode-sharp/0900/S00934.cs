namespace leetcode_sharp;

// 934. Shortest Bridge
// https://leetcode.com/problems/shortest-bridge/
public class S00934
{
    private int[,] _visit;
    private readonly int[] _directions = [0, 1, 0, -1, 0];

    public int ShortestBridge(int[][] grid)
    {
        var n = grid.Length;
        var m = grid[0].Length;
        _visit = new int[n, m];
        var queue = new Queue<(int row, int col)>();

        findIsland(grid, n, m, queue);

        var count = 0;
        while (queue.Count != 0)
        {
            var size = queue.Count;
            while (size-- > 0)
            {
                var (row, col) = queue.Dequeue();
                _visit[row, col] = 1;

                for (var i = 0; i < 4; i++)
                {
                    var nextRow = row + _directions[i];
                    var nextCol = col + _directions[i + 1];

                    if (nextRow < n && nextRow >= 0 && nextCol < m && nextCol >= 0 && _visit[nextRow, nextCol] == 0)
                    {
                        queue.Enqueue((nextRow, nextCol));
                        _visit[nextRow, nextCol] = 1;
                        if (grid[nextRow][nextCol] == 1)
                        {
                            return count;
                        }
                    }
                }
            }

            count++;
        }

        return -1;
    }

    private void findIsland(IReadOnlyList<int[]> grid, int n, int m, Queue<(int row, int col)> queue)
    {
        var flag = false;

        for (var i = 0; i < n && !flag; i++)
        {
            for (var j = 0; j < m && !flag; j++)
            {
                if (_visit[i, j] == 0 && grid[i][j] == 1)
                {
                    dfs(i, j, grid, queue);
                    flag = true;
                }
            }
        }
    }

    private void dfs(int row, int col, IReadOnlyList<int[]> grid, Queue<(int row, int col)> queue)
    {
        var n = grid.Count;
        var m = grid[0].Length;
        queue.Enqueue((row, col));
        _visit[row, col] = 1;

        for (var i = 0; i < 4; i++)
        {
            var nextRow = row + _directions[i];
            var nextCol = col + _directions[i + 1];

            if (nextRow < n && nextRow >= 0 && nextCol < m && nextCol >= 0 && _visit[nextRow, nextCol] == 0 && grid[nextRow][nextCol] == 1)
            {
                dfs(nextRow, nextCol, grid, queue);
            }
        }
    }
}