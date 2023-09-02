namespace leetcode_sharp;

// 628. Maximum Product of Three Numbers
// https://leetcode.com/problems/maximum-product-of-three-numbers/
public class S00628
{
    public int MaximumProduct(int[] nums)
    {
        Array.Sort(nums);
        var n = nums.Length;
        return Math.Max(nums[0] * nums[1] * nums[n - 1], nums[n - 1] * nums[n - 2] * nums[n - 3]);
    }
}