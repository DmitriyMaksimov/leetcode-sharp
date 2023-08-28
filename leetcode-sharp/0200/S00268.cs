namespace leetcode_sharp;

// 268. Missing Number
// https://leetcode.com/problems/missing-number/
public class S00268
{
    public int MissingNumber(int[] nums)
    {
        var n = nums.Length;
        var sum = (n + 1) * n / 2;

        return nums.Aggregate(sum, (current, num) => current - num);
    }
}