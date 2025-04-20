namespace leetcode_sharp;

// 3523. Make Array Non-decreasing
// https://leetcode.com/problems/make-array-non-decreasing
public class S03523
{
    public int MaximumPossibleSize(int[] nums)
    {
        var result = 0;
        var prev = -1;

        foreach (var num in nums)
        {
            if (num >= prev)
            {
                prev = num;
                result++;
            }
        }

        return result;
    }
}
