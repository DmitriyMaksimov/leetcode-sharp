namespace leetcode_sharp;

// 2742. Painting the Walls
// https://leetcode.com/problems/painting-the-walls
public class S02742
{
    private long[,] _dp = null!;

    public int PaintWalls(int[] cost, int[] time)
    {
        _dp = new long[cost.Length + 1, cost.Length + 1];

        return (int) helper(cost, time, 0, 0);
    }

    private long helper(IReadOnlyList<int> cost, IReadOnlyList<int> time, int i, int t)
    {
        if (t >= cost.Count)
        {
            return 0;
        }

        if (i == cost.Count)
        {
            return int.MaxValue;
        }

        if (_dp[i, t] != 0)
        {
            return _dp[i, t];
        }

        return _dp[i, t] = Math.Min(cost[i] + helper(cost, time, i + 1, t + 1 + time[i]), helper(cost, time, i + 1, t));
    }
}