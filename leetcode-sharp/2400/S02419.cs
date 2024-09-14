namespace leetcode_sharp;

// 2419. Longest Subarray With Maximum Bitwise AND
// https://leetcode.com/problems/longest-subarray-with-maximum-bitwise-and
public class S02419
{
    public int LongestSubarray(int[] nums)
    {
        var result = 0;
        var length = 0;
        var max = nums.Max();

        foreach (var num in nums)
        {
            if (num == max)
            {
                result = Math.Max(result, ++length);
            }
            else
            {
                length = 0;
            }
        }

        return result;
    }
}
