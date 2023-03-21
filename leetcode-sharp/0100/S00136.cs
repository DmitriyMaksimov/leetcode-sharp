namespace leetcode_sharp;

// 136. Single Number
// https://leetcode.com/problems/single-number/
public class S00136
{
    public int SingleNumber(int[] nums)
    {
        return nums.Aggregate(0, (current, n) => current ^ n);
    }
}