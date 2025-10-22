namespace leetcode_sharp;

// 3347. Maximum Frequency of an Element After Performing Operations II
// https://leetcode.com/problems/maximum-frequency-of-an-element-after-performing-operations-ii
public class S03347
{
    public int MaxFrequency(int[] nums, int k, int numOperations)
    {
        Array.Sort(nums);
        var n = nums.Length;
        var maxFreq = GetMaxFreq(nums, k, numOperations, n);

        if (maxFreq >= numOperations)
        {
            return maxFreq;
        }

        var maxFreqNoTarget = 0;

        for (int right = 0, left = 0; right < n; right++)
        {
            var val = nums[right];
            while (nums[left] < val - 2 * k)
            {
                left++;
            }

            maxFreqNoTarget = Math.Max(maxFreqNoTarget, right - left + 1);
        }

        return Math.Max(maxFreq, Math.Min(maxFreqNoTarget, numOperations));
    }

    private static int GetMaxFreq(int[] nums, int k, int numOperations, int n)
    {
        var maxFreq = 0;
        var left = 0;
        var right = 0;

        for (var i = 0; i < n;)
        {
            var target = nums[i];
            var count = 0;

            while (i < n && nums[i] == target)
            {
                count++;
                i++;
            }

            while (left < n && nums[left] < target - k)
            {
                left++;
            }

            while (right < n && nums[right] <= target + k)
            {
                right++;
            }

            maxFreq = Math.Max(maxFreq, Math.Min(right - left, count + numOperations));
        }

        return maxFreq;
    }
}