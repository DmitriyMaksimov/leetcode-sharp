namespace leetcode_sharp;

// 3689. Maximum Total Subarray Value I
// https://leetcode.com/problems/maximum-total-subarray-value-i
public class S03689
{
    public long MaxTotalValue(int[] nums, int k)
    {
        return (long)k * (nums.Max() - nums.Min());
    }
}