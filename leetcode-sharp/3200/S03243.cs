namespace leetcode_sharp;

// 3243. Shortest Distance After Road Addition Queries I
// https://leetcode.com/problems/shortest-distance-after-road-addition-queries-i
public class S03243
{
    public int[] ShortestDistanceAfterQueries(int n, int[][] queries)
    {
        var roads = new List<List<int>>(new List<int>[n]);
        for (var i = 0; i < n; i++)
        {
            roads[i] = [];
        }

        var dp = Enumerable.Range(0, n).ToArray();
        var result = new List<int>();

        foreach (var q in queries)
        {
            roads[q[1]].Add(q[0]);

            for (var i = q[1]; i < n; i++)
            {
                dp[i] = Math.Min(dp[i], dp[i - 1] + 1);

                foreach (var l in roads[i])
                {
                    dp[i] = Math.Min(dp[i], dp[l] + 1);
                }
            }

            result.Add(dp[n - 1]);
        }

        return result.ToArray();
    }
}
