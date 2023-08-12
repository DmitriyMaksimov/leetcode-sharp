namespace leetcode_sharp;

// 56. Merge Intervals
// https://leetcode.com/problems/merge-intervals/
public class S00056
{
    public int[][] Merge(int[][] intervals)
    {
        var result = new List<int[]>();

        Array.Sort(intervals, (a, b) => a[0] - b[0]);

        result.Add(intervals[0]);

        for (var i = 1; i < intervals.Length; i++)
        {
            if (result[^1][1] >= intervals[i][0])
            {
                if (result[^1][1] <= intervals[i][1])
                {
                    result[^1][1] = intervals[i][1];
                }
            }
            else
            {
                result.Add(intervals[i]);
            }
        }

        return result.ToArray();
    }
}