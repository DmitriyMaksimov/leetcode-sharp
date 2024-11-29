namespace leetcode_sharp;

// 2577. Minimum Time to Visit a Cell In a Grid
// https://leetcode.com/problems/minimum-time-to-visit-a-cell-in-a-grid
public class S02577
{
    private static readonly int[] Directions = [0, 1, 0, -1, 0];

    public int MinimumTime(int[][] grid)
    {
        var m = grid.Length;
        var n = grid[0].Length;

        if (grid[0][1] > 1 && grid[1][0] > 1)
        {
            return -1;
        }

        var visited = new bool[m, n];

        var heap = new SortedSet<(int t, int r, int c)>(
            Comparer<(int t, int r, int c)>.Create((a, b) =>
                a.t == b.t ? (a.r == b.r ? a.c.CompareTo(b.c) : a.r.CompareTo(b.r)) : a.t.CompareTo(b.t)
            )
        ) { (0, 0, 0) };

        while (heap.Count > 0)
        {
            var (time, row, col) = heap.Min;
            heap.Remove(heap.Min);

            if (row == m - 1 && col == n - 1)
            {
                return time;
            }

            if (visited[row, col])
            {
                continue;
            }

            visited[row, col] = true;

            for (var dir = 0; dir < Directions.Length - 1; ++dir)
            {
                var newRow = row + Directions[dir];
                var newCol = col + Directions[dir + 1];

                if (newRow < 0 || newRow >= m || newCol < 0 || newCol >= n || visited[newRow, newCol])
                {
                    continue;
                }

                var wait = (grid[newRow][newCol] - time) % 2 == 0;
                var nt = Math.Max(grid[newRow][newCol] + (wait ? 1 : 0), time + 1);

                heap.Add((nt, newRow, newCol));
            }
        }

        return -1;
    }
}
