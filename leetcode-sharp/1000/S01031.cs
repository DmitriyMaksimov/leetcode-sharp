namespace leetcode_sharp;

// 1031. Maximum Sum of Two Non-Overlapping Subarrays
// https://leetcode.com/problems/maximum-sum-of-two-non-overlapping-subarrays
public class S01031
{
    public int MaxSumTwoNoOverlap(int[] nums, int firstLen, int secondLen)
    {
        var prefixSum = new int[nums.Length + 1];

        for (var i = 0; i < nums.Length; ++i)
        {
            prefixSum[i + 1] = prefixSum[i] + nums[i];
        }

        return Math.Max(MaxSum(prefixSum, firstLen, secondLen), MaxSum(prefixSum, secondLen, firstLen));
    }

    private static int MaxSum(int[] p, int firstLen, int secondLen)
    {
        var result = 0;

        for (int i = firstLen + secondLen, maxLen = 0; i < p.Length; ++i)
        {
            maxLen = Math.Max(maxLen, p[i - secondLen] - p[i - secondLen - firstLen]);
            result = Math.Max(result, maxLen + p[i] - p[i - secondLen]);
        }

        return result;
    }
}
