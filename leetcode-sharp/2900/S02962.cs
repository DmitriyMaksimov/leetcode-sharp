namespace leetcode_sharp;

// 2962. Count Subarrays Where Max Element Appears at Least K Times
// https://leetcode.com/problems/count-subarrays-where-max-element-appears-at-least-k-times
public class S02962
{
    public long CountSubarrays(int[] nums, int k)
    {
        var max = nums.Max();
        var currentCount = 0;
        var left = 0;
        var result = 0L;
        
        foreach (var num in nums)
        {
            currentCount += num == max ? 1 : 0;

            while (currentCount >= k)
            {
                currentCount -= nums[left] == max ? 1 : 0;
                ++left;
            }

            result += left;
        }

        return result;
    }
}