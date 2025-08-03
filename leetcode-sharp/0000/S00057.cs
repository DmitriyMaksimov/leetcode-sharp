namespace leetcode_sharp;

// 57. Insert Interval
// https://leetcode.com/problems/insert-interval/
public class S00057
{
    public int[][] Insert(int[][] intervals, int[] newInterval)
    {
        var result = new List<int[]>();
        intervals = insertInterval(intervals, newInterval);

        for (var i = 0; i < intervals.Length; i++)
        {
            var currInterval = new[] {intervals[i][0], intervals[i][1]};

            while (i < intervals.Length && overlaps(currInterval, intervals[i]))
            {
                currInterval = merge(currInterval, intervals[i]);
                i++;
            }

            i--;
            result.Add(currInterval);
        }

        return result.ToArray();
    }

    private int[][] insertInterval(int[][] intervals, int[] newInterval)
    {
        var result = intervals.ToList();
        var start = newInterval[0];

        var isIntervalInserted = false;

        for (var i = 0; i < intervals.Length; i++)
        {
            if (start < intervals[i][0])
            {
                result.Insert(i, newInterval);
                isIntervalInserted = true;
                break;
            }
        }

        if (!isIntervalInserted)
        {
            result.Add(newInterval);
        }

        return result.ToArray();
    }

    private static bool overlaps(int[] a, int[] b)
    {
        return Math.Min(a[1], b[1]) - Math.Max(a[0], b[0]) >= 0;
    }

    private static int[] merge(int[] a, int[] b)
    {
        return [Math.Min(a[0], b[0]), Math.Max(a[1], b[1])];
    }
}