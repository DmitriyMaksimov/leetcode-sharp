namespace leetcode_sharp;

// 3651. Minimum Cost Path with Teleportations
// https://leetcode.com/problems/minimum-cost-path-with-teleportations
public class S03651
{
    private static readonly int[] Dx = [0, 1];
    private static readonly int[] Dy = [1, 0];
    
    public int MinCost(int[][] grid, int k)
    {
        var m = grid.Length;
        var n = grid[0].Length;

        var dist = new int[k + 1, m, n];
        for (var t = 0; t <= k; t++)
        {
            for (var i = 0; i < m; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    dist[t, i, j] = int.MaxValue;
                }
            }
        }

        var cells = new List<(int val, int x, int y)>();

        for (var i = 0; i < m; i++)
        {
            for (var j = 0; j < n; j++)
            {
                cells.Add((grid[i][j], i, j));
            }
        }

        cells.Sort((a, b) => a.val.CompareTo(b.val));

        var pq = new PriorityQueue<(int cost, int x, int y, int t), int>();
        dist[0, 0, 0] = 0;
        pq.Enqueue((0, 0, 0, 0), 0);

        var activated = new int[k + 1];

        while (pq.Count > 0)
        {
            var (cost, x, y, t) = pq.Dequeue();
            if (cost > dist[t, x, y])
            {
                continue;
            }

            if (x == m - 1 && y == n - 1)
            {
                return cost;
            }

            for (var d = 0; d < 2; d++)
            {
                var newX = x + Dx[d];
                var newY = y + Dy[d];

                if (newX < m && newY < n)
                {
                    var nc = cost + grid[newX][newY];

                    if (nc < dist[t, newX, newY])
                    {
                        dist[t, newX, newY] = nc;
                        pq.Enqueue((nc, newX, newY, t), nc);
                    }
                }
            }

            if (t < k)
            {
                var idx = activated[t];

                while (idx < cells.Count && cells[idx].val <= grid[x][y])
                {
                    var (_, tx, ty) = cells[idx];
                    if (cost < dist[t + 1, tx, ty])
                    {
                        dist[t + 1, tx, ty] = cost;
                        pq.Enqueue((cost, tx, ty, t + 1), cost);
                    }

                    idx++;
                }

                activated[t] = idx;
            }
        }

        return -1;
    }
}