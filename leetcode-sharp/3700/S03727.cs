namespace leetcode_sharp;

// 3727. Maximum Alternating Sum of Squares
// https://leetcode.com/problems/maximum-alternating-sum-of-squares
public class S03727
{
    public long MaxAlternatingSum(int[] nums)
    {
        var n = nums.Length;
        var ordered = nums.OrderBy(Math.Abs).ToArray();
        return ordered[(n / 2)..].Sum(x => (long)x * x) - ordered[.. (n / 2)].Sum(x => (long)x * x);
    }
}