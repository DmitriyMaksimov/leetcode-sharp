namespace leetcode_sharp;

// 3105. Longest Strictly Increasing or Strictly Decreasing Subarray
// https://leetcode.com/problems/longest-strictly-increasing-or-strictly-decreasing-subarray
public class S03105
{
    public int LongestMonotonicSubarray(int[] nums)
    {
        var maxLength = 1;
        var incLength = 1;
        var decLength = 1;
        
        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i] > nums[i - 1])
            {
                incLength++;
                decLength = 1;
            }
            else if (nums[i] < nums[i - 1])
            {
                decLength++;
                incLength = 1;
            }
            else
            {
                incLength = 1;
                decLength = 1;
            }

            maxLength = Math.Max(maxLength, Math.Max(incLength, decLength));
        }

        return maxLength;
    }
}