namespace leetcode_sharp;

// 3510. Minimum Pair Removal to Sort Array II
// https://leetcode.com/problems/minimum-pair-removal-to-sort-array-ii
public class S03510
{
    public int MinimumPairRemoval(int[] nums)
    {
        var n = nums.Length;
        var a = nums.Select(x => (long)x).ToArray();

        var comparer = Comparer<(long sum, int index)>.Create((x, y) =>
        {
            var cmp = x.sum.CompareTo(y.sum);
            return cmp != 0 ? cmp : x.index.CompareTo(y.index);
        });
        var set = new SortedSet<(long sum, int index)>(comparer);

        var next = new int[n];
        var prev = new int[n];

        for (var i = 0; i < n; i++)
        {
            next[i] = i + 1;
            prev[i] = i - 1;
        }

        var count = 0;
        for (var i = 0; i < n - 1; i++)
        {
            if (a[i] > a[i + 1])
            {
                count++;
            }

            set.Add((a[i] + a[i + 1], i));
        }

        var result = 0;

        while (count > 0)
        {
            var (sum, i) = set.Min!;
            var j = next[i];
            var p = prev[i];
            var q = next[j];

            if (a[i] > a[j])
            {
                count--;
            }

            if (p >= 0)
            {
                if (a[p] > a[i] && a[p] <= a[i] + a[j])
                {
                    count--;
                }
                else if (a[p] <= a[i] && a[p] > a[i] + a[j])
                {
                    count++;
                }
            }

            if (q < n)
            {
                if (a[q] >= a[j] && a[q] < a[i] + a[j])
                {
                    count++;
                }
                else if (a[q] < a[j] && a[q] >= a[i] + a[j])
                {
                    count--;
                }
            }

            set.Remove((sum, i));

            if (p >= 0)
            {
                set.Remove((a[p] + a[i], p));
                set.Add((a[p] + a[i] + a[j], p));
            }

            if (q < n)
            {
                set.Remove((a[j] + a[q], j));
                set.Add((a[i] + a[j] + a[q], i));
                prev[q] = i;
            }

            next[i] = q;
            a[i] += a[j];
            result++;
        }

        return result;
    }
}