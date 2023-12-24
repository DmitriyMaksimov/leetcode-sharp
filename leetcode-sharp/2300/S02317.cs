namespace leetcode_sharp;

// 2317. Maximum XOR After Operations
// https://leetcode.com/problems/maximum-xor-after-operations
public class S02317
{
    public int MaximumXOR(int[] nums)
    {
        return nums.Aggregate(0, (current, num) => current | num);
    }
}