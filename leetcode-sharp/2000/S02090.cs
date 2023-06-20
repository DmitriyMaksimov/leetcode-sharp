namespace leetcode_sharp;

// 2090. K Radius Subarray Averages
// https://leetcode.com/problems/k-radius-subarray-averages/
public class S02090
{
    public int[] GetAverages(int[] nums, int k)
    {
        var n = nums.Length;
        var windowSize = 2 * k + 1;
        var ans = new int[n];
        Array.Fill(ans, -1);

        if (n < windowSize)
        {
            return ans;
        }

        var prefixSum = new long[n + 1];
        for (var i = 0; i < n; ++i)
        {
            prefixSum[i + 1] = prefixSum[i] + nums[i];
        }

        for (var i = k; i + k < n; ++i)
        {
            ans[i] = (int) ((prefixSum[i + k + 1] - prefixSum[i - k]) / windowSize);
        }

        return ans;
    }
}