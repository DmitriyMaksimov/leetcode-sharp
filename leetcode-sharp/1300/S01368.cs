namespace leetcode_sharp;

// 1368. Minimum Cost to Make at Least One Valid Path in a Grid
// https://leetcode.com/problems/minimum-cost-to-make-at-least-one-valid-path-in-a-grid
public class S01368
{
    public int MinCost(int[][] grid)
    {
        var m = grid.Length;
        var n = grid[0].Length;

        var minCost = new Dictionary<(int, int), int> { [(0, 0)] = 0 };

        var deque = new LinkedList<(int cost, int y, int x)>();
        deque.AddFirst((0, 0, 0));

        while (deque.Count > 0)
        {
            var (cost, y, x) = deque.First!.Value;
            deque.RemoveFirst();

            if (minCost[(y, x)] < cost)
            {
                continue;
            }

            if (y == m - 1 && x == n - 1)
            {
                return cost;
            }

            foreach (var (ny, nx, stepCost) in Neighborhood(grid, y, x, n, m))
            {
                var newCost = cost + stepCost;

                if (!minCost.ContainsKey((ny, nx)) || newCost < minCost[(ny, nx)])
                {
                    minCost[(ny, nx)] = newCost;

                    if (stepCost == 0)
                    {
                        deque.AddFirst((newCost, ny, nx));
                    }
                    else
                    {
                        deque.AddLast((newCost, ny, nx));
                    }
                }
            }
        }

        return 0;
    }

    private static IEnumerable<(int, int, int)> Neighborhood(int[][] grid, int y, int x, int n, int m)
    {
        if (x + 1 < n)
        {
            yield return (y, x + 1, grid[y][x] == 1 ? 0 : 1);
        }

        if (x > 0)
        {
            yield return (y, x - 1, grid[y][x] == 2 ? 0 : 1);
        }

        if (y + 1 < m)
        {
            yield return (y + 1, x, grid[y][x] == 3 ? 0 : 1);
        }

        if (y > 0)
        {
            yield return (y - 1, x, grid[y][x] == 4 ? 0 : 1);
        }
    }
}
