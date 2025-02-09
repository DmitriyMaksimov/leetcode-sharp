namespace leetcode_sharp;

// 2364. Count Number of Bad Pairs
// https://leetcode.com/problems/count-number-of-bad-pairs
public class S02364
{
    public long CountBadPairs(int[] nums)
    {
        var n = nums.Length;
        var totalPairs = (long)n * (n - 1) / 2;
        var diffCounts = new Dictionary<int, int>();

        long goodPairs = 0;

        for (var i = 0; i < n; i++)
        {
            var diff = nums[i] - i;
            if (diffCounts.TryGetValue(diff, out var count))
            {
                goodPairs += count;
                diffCounts[diff] = count + 1;
            }
            else
            {
                diffCounts[diff] = 1;
            }
        }

        return totalPairs - goodPairs;
    }
}
