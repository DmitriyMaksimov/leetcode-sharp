namespace leetcode_sharp;

// 2615. Sum of Distances
// https://leetcode.com/problems/sum-of-distances
public class S02615
{
    public long[] Distance(int[] nums)
    {
        var n = nums.Length;
        var result = new long[n];

        var map = new Dictionary<int, List<int>>();
        for (var i = 0; i < n; i++)
        {
            if (!map.ContainsKey(nums[i]))
            {
                map[nums[i]] = [];
            }

            map[nums[i]].Add(i);
        }

        foreach (var (_, indices) in map)
        {
            var totalSum = indices.Sum(i => (long)i);
            long prefixSum = 0;

            for (var i = 0; i < indices.Count; i++)
            {
                var index = indices[i];
                var suffixSum = totalSum - prefixSum - index;

                result[index] += index * (long)i;
                result[index] -= prefixSum;
                result[index] -= index * (long)(indices.Count - i - 1);
                result[index] += suffixSum;

                prefixSum += index;
            }
        }

        return result;
    }
}