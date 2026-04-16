namespace leetcode_sharp;

// 3488. Closest Equal Element Queries
// https://leetcode.com/problems/closest-equal-element-queries
public class S03488
{
    public IList<int> SolveQueries(int[] nums, int[] queries)
    {
        var lastSeen = new Dictionary<int, int>();
        var rightSeen = new Dictionary<int, int>();
        var dist = new List<int>();
        var n = nums.Length;

        for (var i = 0; i < n * 2; i++)
        {
            if (i < n)
            {
                dist.Add(n + 1);
            }

            var value = nums[i % n];

            if (lastSeen.TryGetValue(value, out var lastIndex))
            {
                var curInd = i % n;
                dist[curInd] = Math.Min(dist[curInd], i - lastIndex);
            }

            lastSeen[value] = i;
        }

        for (var i = n * 2 - 1; i >= 0; i--)
        {
            var value = nums[i % n];

            if (rightSeen.TryGetValue(value, out var rightIndex))
            {
                var curInd = i % n;
                dist[curInd] = Math.Min(dist[curInd], rightIndex - i);
            }

            rightSeen[value] = i;
        }

        return queries.Select(q => dist[q] >= n ? -1 : dist[q]).ToList();
    }
}