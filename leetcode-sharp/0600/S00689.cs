namespace leetcode_sharp;

// 689. Maximum Sum of 3 Non-Overlapping Subarrays
// https://leetcode.com/problems/maximum-sum-of-3-non-overlapping-subarrays
public class S00689
{
    public int[] MaxSumOfThreeSubarrays(int[] nums, int k)
    {
        var n = nums.Length;
        var prefixSum = new int[n + 1];

        for (var i = 0; i < n; i++)
        {
            prefixSum[i + 1] = prefixSum[i] + nums[i];
        }

        var leftMaxIndices = new int[n];

        for (int i = k, currentMax = prefixSum[k] - prefixSum[0]; i < n; i++)
        {
            var windowSum = prefixSum[i + 1] - prefixSum[i + 1 - k];
            if (windowSum > currentMax)
            {
                leftMaxIndices[i] = i + 1 - k;
                currentMax = windowSum;
            }
            else
            {
                leftMaxIndices[i] = leftMaxIndices[i - 1];
            }
        }

        var rightMaxIndices = new int[n];
        rightMaxIndices[n - k] = n - k;

        for (int i = n - k - 1, currentMax = prefixSum[n] - prefixSum[n - k]; i >= 0; i--)
        {
            var windowSum = prefixSum[i + k] - prefixSum[i];
            if (windowSum >= currentMax)
            {
                rightMaxIndices[i] = i;
                currentMax = windowSum;
            }
            else
            {
                rightMaxIndices[i] = rightMaxIndices[i + 1];
            }
        }

        var maxSum = 0;
        var result = new int[3];

        for (var midStart = k; midStart <= n - 2 * k; midStart++)
        {
            var leftStart = leftMaxIndices[midStart - 1];
            var rightStart = rightMaxIndices[midStart + k];

            var totalSum = (prefixSum[midStart + k] - prefixSum[midStart]) +
                           (prefixSum[leftStart + k] - prefixSum[leftStart]) +
                           (prefixSum[rightStart + k] - prefixSum[rightStart]);

            if (totalSum > maxSum)
            {
                maxSum = totalSum;
                result[0] = leftStart;
                result[1] = midStart;
                result[2] = rightStart;
            }
        }

        return result;
    }
}
