namespace leetcode_sharp;

// 2401. Longest Nice Subarray
// https://leetcode.com/problems/longest-nice-subarray
public class S02401
{
    public int LongestNiceSubarray(int[] nums)
    {
        var used = 0;
        var right = 0;
        var result = 0;

        for (var left = 0; left < nums.Length; ++left)
        {
            while ((used & nums[left]) != 0)
            {
                used ^= nums[right++];
            }

            used |= nums[left];
            result = Math.Max(result, left - right + 1);
        }

        return result;
    }
}
