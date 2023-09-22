namespace leetcode_sharp;

// 2357. Make Array Zero by Subtracting Equal Amounts
// https://leetcode.com/problems/make-array-zero-by-subtracting-equal-amounts/
public class S02357
{
    public int MinimumOperations(int[] nums)
    {
        return nums.Distinct().Count(x => x != 0);
    }
}