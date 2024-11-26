namespace leetcode_sharp;

// 1288. Remove Covered Intervals
// https://leetcode.com/problems/remove-covered-intervals
public class S01288
{
    public int RemoveCoveredIntervals(int[][] intervals)
    {
        Array.Sort(intervals, (a, b) => a[0] == b[0] ? b[1].CompareTo(a[1]) : a[0].CompareTo(b[0]));

        var x1 = intervals[0][0];
        var x2 = intervals[0][1];
        var result = 1;

        for (var i = 1; i < intervals.Length; ++i)
        {
            if (intervals[i][0] > x1 && intervals[i][1] > x2)
            {
                ++result;
            }

            if (intervals[i][1] > x2)
            {
                x1 = intervals[i][0];
                x2 = intervals[i][1];
            }
        }

        return result;
    }
}
