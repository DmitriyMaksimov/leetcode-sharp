namespace leetcode_sharp;

// 1493. Longest Subarray of 1's After Deleting One Element
// https://leetcode.com/problems/longest-subarray-of-1s-after-deleting-one-element/
public class S01493
{
    public int LongestSubarray(int[] nums)
    {
        var n = nums.Length;
        var left = 0;
        var zeros = 0;
        var result = 0;

        for (var right = 0; right < n; right++)
        {
            if (nums[right] == 0)
            {
                zeros++;
            }

            while (zeros > 1)
            {
                if (nums[left++] == 0)
                {
                    zeros--;
                }
            }

            result = Math.Max(result, right - left + 1 - zeros);
        }

        return result == n ? result - 1 : result;
    }
}