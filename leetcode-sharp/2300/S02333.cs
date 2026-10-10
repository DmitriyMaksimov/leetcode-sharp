namespace leetcode_sharp;

// 2333. Minimum Sum of Squared Difference
// https://leetcode.com/problems/minimum-sum-of-squared-difference
public class S02333
{
    public long MinSumSquareDiff(int[] nums1, int[] nums2, int k1, int k2)
    {
        var diff = nums1.Select((x, index) => Math.Abs(nums2[index] - x)).ToArray();
        var max = diff.Max();
        var bucket = new int[max + 1];
        
        foreach (var d in diff)
        {
            bucket[d]++;
        }

        var k = k1 + k2;

        for (var i = max; i > 0; i--)
        {
            if (bucket[i] <= 0)
            {
                continue;
            }

            var minus = Math.Min(bucket[i], k);
            bucket[i] -= minus;
            bucket[i - 1] += minus;
            k -= minus;
        }

        var result = 0L;

        for (var i = 0L; i <= max; i++)
        {
            result += bucket[i] * i * i;
        }

        return result;
    }
}