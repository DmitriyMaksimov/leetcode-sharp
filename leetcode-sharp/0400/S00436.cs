namespace leetcode_sharp;

// 436. Find Right Interval
// https://leetcode.com/problems/find-right-interval
public class S00436
{
    public int[] FindRightInterval(int[][] intervals)
    {
        var n = intervals.Length;
        var result = new int[n];

        List<(int Start, int Index)> starts = Enumerable.Range(0, n).Select(i => (intervals[i][0], i)).ToList();

        starts.Sort((a, b) => a.Start.CompareTo(b.Start));

        for (var i = 0; i < n; i++)
        {
            var end = intervals[i][1];
            var startIndex = BinarySearch(starts, end);

            result[i] = startIndex == -1 ? -1 : starts[startIndex].Index;
        }

        return result;
    }

    private static int BinarySearch(List<(int Start, int Index)> starts, int target)
    {
        var left = 0;
        var right = starts.Count - 1;

        while (left <= right)
        {
            var mid = left + (right - left) / 2;

            if (starts[mid].Start < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return left < starts.Count ? left : -1;
    }
}
