namespace leetcode_sharp;

// 3342. Find Minimum Time to Reach Last Room II
// https://leetcode.com/problems/find-minimum-time-to-reach-last-room-ii
public class S03342
{
    private readonly int[] _directions = [0, -1, 0, 1, 0];

    public int MinTimeToReach(int[][] moveTime)
    {
        var n = moveTime.Length;
        var m = moveTime[0].Length;

        var pq = new PriorityQueue<(long time, int x, int y, int alternate), long>();

        var minimumTime = new long[n][];
        for (var i = 0; i < n; i++)
        {
            minimumTime[i] = Enumerable.Repeat(long.MaxValue, m).ToArray();
        }

        pq.Enqueue((0, 0, 0, 0), 0);
        minimumTime[0][0] = 0;

        while (pq.Count > 0)
        {
            var (currentTime, x, y, alternate) = pq.Dequeue();

            if (minimumTime[x][y] < currentTime)
            {
                continue;
            }

            if (x == n - 1 && y == m - 1)
            {
                return (int)currentTime;
            }

            long nx = alternate == 0 ? 1 : 0;
            long ex = alternate == 0 ? 1 : 2;

            for (var i = 0; i < _directions.Length - 1; i++)
            {
                var xn = x + _directions[i];
                var yn = y + _directions[i + 1];

                if (xn >= 0 && xn < n && yn >= 0 && yn < m)
                {
                    long a = moveTime[xn][yn];
                    var now = Math.Max(currentTime + ex, a + ex);

                    if (minimumTime[xn][yn] > now)
                    {
                        minimumTime[xn][yn] = now;
                        pq.Enqueue((now, xn, yn, (int)nx), now);
                    }
                }
            }
        }

        return -1;
    }
}
