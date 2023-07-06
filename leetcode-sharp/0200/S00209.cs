namespace leetcode_sharp;

// 209. Minimum Size Subarray Sum
// https://leetcode.com/problems/minimum-size-subarray-sum/
public class S00209
{
    public int MinSubArrayLen(int target, int[] nums)
    {
        var left = 0;
        var right = 0;
        var sum = 0;
        var result = int.MaxValue;

        while (right < nums.Length)
        {
            sum += nums[right];
            while (sum >= target)
            {
                result = Math.Min(result, right - left + 1);
                sum -= nums[left++];
            }

            ++right;
        }

        return result == int.MaxValue ? 0 : result;
    }
}