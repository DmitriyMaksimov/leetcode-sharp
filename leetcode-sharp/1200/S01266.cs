namespace leetcode_sharp;

// 1266. Minimum Time Visiting All Points
// https://leetcode.com/problems/minimum-time-visiting-all-points/
public class S01266
{
    public int MinTimeToVisitAllPoints(int[][] points)
    {
        var ans = 0;
        
        for (var i = 1; i < points.Length; ++i)
        {
            var cur = points[i];
            var prev = points[i - 1];

            ans += Math.Max(Math.Abs(cur[0] - prev[0]), Math.Abs(cur[1] - prev[1]));
        }

        return ans;
    }
}