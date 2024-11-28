namespace leetcode_sharp;

// 2290. Minimum Obstacle Removal to Reach Corner
// https://leetcode.com/problems/minimum-obstacle-removal-to-reach-corner
public class S02290
{
    private static readonly int[] Directions = [0, 1, 0, -1, 0];

    public int MinimumObstacles(int[][] grid)
    {
        var m = grid.Length;
        var n = grid[0].Length;
        var dist = new int[m, n];

        for (var i = 0; i < m; i++)
        {
            for (var j = 0; j < n; j++)
            {
                dist[i, j] = int.MaxValue;
            }
        }

        dist[0, 0] = grid[0][0];

        var queue = new PriorityQueue<(int cost, int row, int column), int>();
        queue.Enqueue((dist[0, 0], 0, 0), dist[0, 0]);

        while (queue.Count > 0)
        {
            var (cost, row, column) = queue.Dequeue();

            if (row == m - 1 && column == n - 1)
            {
                return cost;
            }

            for (var k = 0; k < Directions.Length - 1; ++k)
            {
                var i = row + Directions[k];
                var j = column + Directions[k + 1];

                if (i >= 0 && i < m && j >= 0 && j < n)
                {
                    var newCost = cost + grid[i][j];

                    if (newCost < dist[i, j])
                    {
                        dist[i, j] = newCost;
                        queue.Enqueue((newCost, i, j), newCost);
                    }
                }
            }
        }

        return dist[m - 1, n - 1];
    }
}
