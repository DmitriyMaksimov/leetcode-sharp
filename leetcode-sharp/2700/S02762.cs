namespace leetcode_sharp;

// 2762. Continuous Subarrays
// https://leetcode.com/problems/continuous-subarrays
public class S02762
{
    public long ContinuousSubarrays(int[] nums)
    {
        var left = 0;
        var right = 0;
        var j = 0;
        var result = 0L;

        for (var i = 0; i < nums.Length; i++)
        {
            if (i == 0)
            {
                ++result;
                left = nums[i] - 2;
                right = nums[i] + 2;
            }
            else if (left <= nums[i] && nums[i] <= right)
            {
                left = Math.Max(left, nums[i] - 2);
                right = Math.Min(right, nums[i] + 2);
                result += i - j + 1;
            }
            else
            {
                j = i - 1;
                left = nums[i] - 2;
                right = nums[i] + 2;

                while (nums[i] - 2 <= nums[j] && nums[j] <= nums[i] + 2)
                {
                    left = Math.Max(left, nums[j] - 2);
                    right = Math.Min(right, nums[j] + 2);
                    --j;
                }

                result += i - ++j + 1;
            }
        }

        return result;
    }
}
