namespace leetcode_sharp;

// 778. Swim in Rising Water
// https://leetcode.com/problems/swim-in-rising-water
public class S00778
{
    private readonly int[] _directions = [0, -1, 0, 1, 0];

    public int SwimInWater(int[][] grid)
    {
        var n = grid.Length;
        var seen = new HashSet<(int, int)>();
        var pq = new PriorityQueue<(int x, int y), int>();
        pq.Enqueue((0, 0), grid[0][0]);
        seen.Add((0, 0));

        var result = 0;
    
        while (pq.Count > 0)
        {
            pq.TryDequeue(out var pos, out var time);
            result = Math.Max(result, time);

            var (x, y) = pos;
            if (x == n - 1 && y == n - 1)
            {
                return result;
            }

            for (var k = 0; k < _directions.Length - 1; ++k)
            {
                var i = x + _directions[k];
                var j = y + _directions[k + 1];

                if (i >= 0 && i < n && j >= 0 && j < n && !seen.Contains((i, j)))
                {
                    pq.Enqueue((i, j), grid[i][j]);
                    seen.Add((i, j));
                }
            }
        }

        return result;
    }
}