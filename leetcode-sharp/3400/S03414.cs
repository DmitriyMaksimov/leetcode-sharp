namespace leetcode_sharp;

// 3414. Maximum Score of Non-overlapping Intervals
// https://leetcode.com/problems/maximum-score-of-non-overlapping-intervals
public class S03414
{
    private readonly record struct Interval(int Start, int End, int Weight, int OriginalIndex);

    private readonly record struct State(long Score, int Count, int Id0, int Id1, int Id2, int Id3)
    {
        public int GetId(int index) => index switch
        {
            0 => Id0,
            1 => Id1,
            2 => Id2,
            3 => Id3,
            _ => throw new ArgumentOutOfRangeException(nameof(index))
        };

        public int[] ToArray()
        {
            var result = new int[Count];

            for (var i = 0; i < Count; i++)
            {
                result[i] = GetId(i);
            }

            return result;
        }
    }

    public int[] MaximumWeight(IList<IList<int>> intervals)
    {
        var n = intervals.Count;

        var events = new Interval[n];

        for (var i = 0; i < n; i++)
        {
            events[i] = new Interval(intervals[i][0], intervals[i][1], intervals[i][2], i);
        }

        // Sort by start position.
        Array.Sort(events, static (a, b) =>
        {
            var result = a.Start.CompareTo(b.Start);

            return result != 0 ? result : a.End.CompareTo(b.End);
        });

        var starts = new int[n];

        for (var i = 0; i < n; i++)
        {
            starts[i] = events[i].Start;
        }

        // next[i] = first event whose start > events[i].End
        var next = new int[n];

        for (var i = 0; i < n; i++)
        {
            next[i] = UpperBound(starts, events[i].End);
        }

         // dp[i, k] = best result using events from i onward,
         //            when we can still select at most k events.
         // k is 0..4.
        var dp = new State[n + 1, 5];

        for (var i = n - 1; i >= 0; i--)
        {
            for (var k = 1; k <= 4; k++)
            {
                // Don't take events[i].
                var skip = dp[i + 1, k];

                // Take events[i].
                var take = AddId(dp[next[i], k - 1], events[i].OriginalIndex, events[i].Weight);

                dp[i, k] = Better(skip, take);
            }
        }

        return dp[0, 4].ToArray();
    }

    private static int UpperBound(int[] values, int target)
    {
        var left = 0;
        var right = values.Length;

        while (left < right)
        {
            var mid = left + (right - left) / 2;

            if (values[mid] <= target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid;
            }
        }

        return left;
    }

    private static State AddId(State state, int id, int weight)
    {
        Span<int> ids = stackalloc int[4];

        for (var i = 0; i < state.Count; i++)
        {
            ids[i] = state.GetId(i);
        }

        var count = state.Count;

        var position = count;

        while (position > 0 && ids[position - 1] > id)
        {
            ids[position] = ids[position - 1];
            position--;
        }

        ids[position] = id;
        count++;

        return new State(state.Score + weight, count, ids[0], ids[1], ids[2], ids[3]);
    }

    private static State Better(State a, State b)
    {
        if (a.Score != b.Score)
        {
            return a.Score > b.Score ? a : b;
        }

        return CompareIds(a, b) <= 0 ? a : b;
    }

    private static int CompareIds(State a, State b)
    {
        var count = Math.Min(a.Count, b.Count);

        for (var i = 0; i < count; i++)
        {
            var comparison = a.GetId(i).CompareTo(b.GetId(i));

            if (comparison != 0)
            {
                return comparison;
            }
        }

        return a.Count.CompareTo(b.Count);
    }
}