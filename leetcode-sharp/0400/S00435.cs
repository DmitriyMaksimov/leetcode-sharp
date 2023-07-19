namespace leetcode_sharp;

// 435. Non-overlapping Intervals
// https://leetcode.com/problems/non-overlapping-intervals/
public class S00435
{
    public int EraseOverlapIntervals(int[][] intervals)
    {
        var n = intervals.Length;
        Array.Sort(intervals, (a, b) => a[1] - b[1]);

        var prev = 0;
        var count = 1;

        for (var i = 1; i < n; i++)
        {
            if (intervals[i][0] >= intervals[prev][1])
            {
                prev = i;
                count++;
            }
        }

        return n - count;
    }
}