namespace leetcode_sharp;

// 2527. Find Xor-Beauty of Array
// https://leetcode.com/problems/find-xor-beauty-of-array
public class S02527
{
    public int XorBeauty(int[] nums)
    {
        return nums.Aggregate(0, (current, num) => current ^ num);
    }
}
