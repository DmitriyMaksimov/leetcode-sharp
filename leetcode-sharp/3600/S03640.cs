namespace leetcode_sharp;

// 3640. Trionic Array II
// https://leetcode.com/problems/trionic-array-ii
public class S03640
{
    private record Triple(int P, int Q, long Sum);

    private static List<Triple> Decompose(int[] nums)
    {
        var n = nums.Length;
        var subarrays = new List<Triple>();

        var l = 0;
        long sum = nums[0];

        for (var i = 1; i < n; i++)
        {
            if (nums[i - 1] <= nums[i])
            {
                subarrays.Add(new Triple(l, i - 1, sum));
                l = i;
                sum = 0;
            }

            sum += nums[i];
        }

        subarrays.Add(new Triple(l, n - 1, sum));

        return subarrays;
    }

    public long MaxSumTrionic(int[] nums)
    {
        var n = nums.Length;
        var maxEndingAt = new long[n];
        
        for (var i = 0; i < n; i++)
        {
            maxEndingAt[i] = nums[i];

            if (i > 0 && nums[i - 1] < nums[i] && maxEndingAt[i - 1] > 0)
            {
                maxEndingAt[i] += maxEndingAt[i - 1];
            }
        }

        var maxStartingAt = new long[n];

        for (var i = n - 1; i >= 0; i--)
        {
            maxStartingAt[i] = nums[i];

            if (i < n - 1 && nums[i] < nums[i + 1] && maxStartingAt[i + 1] > 0)
            {
                maxStartingAt[i] += maxStartingAt[i + 1];
            }
        }

        var pqs = Decompose(nums);
        var result = long.MinValue;

        foreach (var (p, q, sum) in pqs)
        {
            if (p > 0 && q < n - 1 && nums[p - 1] < nums[p] && nums[q] < nums[q + 1] && p < q)
            {
                var candidate = maxEndingAt[p - 1] + sum + maxStartingAt[q + 1];
                result = Math.Max(result, candidate);
            }
        }

        return result;
    }
}