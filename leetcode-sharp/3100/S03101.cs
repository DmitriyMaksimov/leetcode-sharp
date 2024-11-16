namespace leetcode_sharp;

// 3101. Count Alternating Subarrays
// https://leetcode.com/problems/count-alternating-subarrays
public class S03101
{
    public long CountAlternatingSubarrays(int[] nums)
    {
        var result = 1L;
        var size = 1L;

        for (var i = 1; i < nums.Length; ++i)
        {
            size = nums[i - 1] == nums[i] ? 1 : size + 1;
            result += size;
        }

        return result;
    }
}
