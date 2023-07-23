namespace leetcode_sharp;

// 1751. Maximum Number of Events That Can Be Attended II
// https://leetcode.com/problems/maximum-number-of-events-that-can-be-attended-ii/
public class S01751
{
    private readonly List<int[]> _dp = new();

    public int MaxValue(int[][] events, int k)
    {
        Array.Sort(events, (a, b) => a[0] - b[0]);
        var n = events.Length;
        for (var i = 0; i < n; i++)
        {
            var cols = new int[k + 1];
            Array.Fill(cols, -1);
            _dp.Add(cols);
        }

        return solve(events, 0, k, 0);
    }

    private int solve(IReadOnlyList<int[]> events, int idx, int k, int end)
    {
        if (idx == events.Count)
        {
            return 0;
        }

        if (k == 0)
        {
            return 0;
        }

        if (events[idx][0] <= end)
        {
            return solve(events, idx + 1, k, end);
        }

        if (_dp[idx][k] != -1)
        {
            return _dp[idx][k];
        }

        var res = Math.Max(events[idx][2] + solve(events, idx + 1, k - 1, events[idx][1]), solve(events, idx + 1, k, end));

        return _dp[idx][k] = res;
    }
}