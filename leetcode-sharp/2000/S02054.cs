namespace leetcode_sharp;

// 2054. Two Best Non-Overlapping Events
// https://leetcode.com/problems/two-best-non-overlapping-events
public class S02054
{
    public int MaxTwoEvents(int[][] events)
    {
        Array.Sort(events, (a, b) => a[0] == b[0] ? a[1].CompareTo(b[1]) : a[0].CompareTo(b[0]));

        var queue = new SortedSet<(int End, int Value)>(Comparer<(int end, int value)>.Create((a, b) => a.end == b.end ? a.value.CompareTo(b.value) : a.end.CompareTo(b.end)));

        var maxVal = 0;
        var result = 0;

        foreach (var e in events)
        {
            var start = e[0];

            while (queue.Count > 0 && queue.Min.End < start)
            {
                var ev = queue.Min;
                queue.Remove(ev);
                maxVal = Math.Max(maxVal, ev.Value);
            }

            result = Math.Max(result, e[2] + maxVal);

            queue.Add((e[1], e[2]));
        }

        return result;
    }
}
