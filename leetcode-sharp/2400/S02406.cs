namespace leetcode_sharp;

// 2406. Divide Intervals Into Minimum Number of Groups
// https://leetcode.com/problems/divide-intervals-into-minimum-number-of-groups
public class S02406
{
    public int MinGroups(int[][] intervals)
    {
        var n = intervals.Length;
        var arr = new int[n * 2][];

        for (var i = 0; i < n; ++i)
        {
            arr[i * 2] = [intervals[i][0], 1];
            arr[i * 2 + 1] = [intervals[i][1] + 1, -1];
        }

        var res = 0;
        var cur = 0;

        foreach (var a in arr.OrderBy(x => x[0] * 3 + x[1]))
        {
            res = Math.Max(res, cur += a[1]);
        }

        return res;
    }
}
