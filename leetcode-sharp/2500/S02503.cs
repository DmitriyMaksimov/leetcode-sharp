namespace leetcode_sharp;

// 2503. Maximum Number of Points From Grid Queries
// https://leetcode.com/problems/maximum-number-of-points-from-grid-queries
public class S02503
{
    public int[] MaxPoints(int[][] grid, int[] queries)
    {
        var m = grid.Length;
        var n = grid[0].Length;

        var vp = queries
            .Select((val, idx) => (val, idx))
            .OrderBy(q => q.val)
            .ToList();

        var result = new int[queries.Length];

        var visited = new bool[m, n];

        var pq = new PriorityQueue<(int val, int i, int j), int>();
        pq.Enqueue((grid[0][0], 0, 0), grid[0][0]);
        visited[0, 0] = true;

        var count = 0;

        foreach (var (val, idx) in vp)
        {
            while (pq.Count > 0)
            {
                var (v, i, j) = pq.Peek();
                if (v >= val) break;

                pq.Dequeue();
                count++;

                // Check all 4 directions
                if (i - 1 >= 0 && !visited[i - 1, j])
                {
                    pq.Enqueue((grid[i - 1][j], i - 1, j), grid[i - 1][j]);
                    visited[i - 1, j] = true;
                }

                if (j - 1 >= 0 && !visited[i, j - 1])
                {
                    pq.Enqueue((grid[i][j - 1], i, j - 1), grid[i][j - 1]);
                    visited[i, j - 1] = true;
                }

                if (i + 1 < m && !visited[i + 1, j])
                {
                    pq.Enqueue((grid[i + 1][j], i + 1, j), grid[i + 1][j]);
                    visited[i + 1, j] = true;
                }

                if (j + 1 < n && !visited[i, j + 1])
                {
                    pq.Enqueue((grid[i][j + 1], i, j + 1), grid[i][j + 1]);
                    visited[i, j + 1] = true;
                }
            }

            result[idx] = count;
        }

        return result;
    }
}
