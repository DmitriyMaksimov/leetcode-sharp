namespace leetcode_sharp;

// 2463. Minimum Total Distance Traveled
// https://leetcode.com/problems/minimum-total-distance-traveled
public class S02463
{
    private const long Max = 10_000_000_000_000_000L;

    public long MinimumTotalDistance(IList<int> robot, int[][] factory)
    {
        robot = robot.Order().ToList();
        Array.Sort(factory, (a, b) => a[0].CompareTo(b[0]));

        var v = new List<int>();
        foreach (var i in factory)
        {
            var position = i[0];
            var limit = i[1];

            for (var j = 0; j < limit; j++)
            {
                v.Add(position);
            }
        }

        var dp = Enumerable.Range(0, robot.Count + 1)
            .Select(_ => Enumerable.Repeat(-1L, v.Count + 1).ToArray())
            .ToArray();

        return Helper(0, 0, robot, v, dp);
    }

    private long Helper(int i, int j, IList<int> robot, List<int> v, long[][] dp)
    {
        if (i == robot.Count)
        {
            return 0;
        }

        if (j == v.Count)
        {
            return Max;
        }

        if (dp[i][j] != -1)
        {
            return dp[i][j];
        }

        var take = Math.Abs(robot[i] - v[j]) + Helper(i + 1, j + 1, robot, v, dp);
        var notTake = Helper(i, j + 1, robot, v, dp);

        return dp[i][j] = Math.Min(take, notTake);
    }
}
