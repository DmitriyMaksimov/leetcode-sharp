namespace leetcode_sharp;

// 3332. Maximum Points Tourist Can Earn
// https://leetcode.com/problems/maximum-points-tourist-can-earn
public class S03332
{
    private static int[][] _dp = null!;

    public int MaxScore(int n, int k, int[][] stayScore, int[][] travelScore)
    {
        _dp = new int[k + 1][];

        for (var i = 0; i <= k; i++)
        {
            _dp[i] = Enumerable.Repeat(-1, n + 1).ToArray();
        }

        var result = 0;

        for (var startCity = 0; startCity < n; ++startCity)
        {
            result = Math.Max(result, Solve(n, k, 0, startCity, stayScore, travelScore));
        }

        return result;
    }

    private static int Solve(int n, int k, int day, int curCity, int[][] stayScore, int[][] travelScore)
    {
        if (day >= k)
        {
            return 0;
        }

        if (_dp[day][curCity] != -1)
        {
            return _dp[day][curCity];
        }

        var result = stayScore[day][curCity] + Solve(n, k, day + 1, curCity, stayScore, travelScore);

        for (var nextCity = 0; nextCity < n; ++nextCity)
        {
            if (nextCity == curCity)
            {
                continue;
            }

            result = Math.Max(result, travelScore[curCity][nextCity] + Solve(n, k, day + 1, nextCity, stayScore, travelScore));
        }

        return _dp[day][curCity] = result;
    }
}
