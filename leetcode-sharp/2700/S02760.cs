namespace leetcode_sharp;

// 2760. Longest Even Odd Subarray With Threshold
// https://leetcode.com/problems/longest-even-odd-subarray-with-threshold
public class S02760
{
    public int LongestAlternatingSubarray(int[] nums, int threshold)
    {
        var result = 0;
        
        for (var left = 0; left < nums.Length; left++)
        {
            if (nums[left] % 2 != 0 || nums[left] > threshold) continue;
            
            var len = 1;

            for (var right = left + 1; right < nums.Length; right++)
            {
                if (nums[right] > threshold || nums[right] % 2 == nums[right - 1] % 2)
                {
                    left = right - 1;
                    break;
                }

                len++;
            }

            result = Math.Max(result, len);
        }

        return result;
    }
}