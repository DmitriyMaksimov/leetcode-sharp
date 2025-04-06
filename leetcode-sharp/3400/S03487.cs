namespace leetcode_sharp;

// 3487. Maximum Unique Subarray Sum After Deletion
// https://leetcode.com/problems/maximum-unique-subarray-sum-after-deletion
public class S03487
{
    public int MaxSum(int[] nums)
    {
        var max = nums.Max();
        return max < 0 ? max : nums.Where(n => n >= 0).Distinct().Sum();
    }
}
