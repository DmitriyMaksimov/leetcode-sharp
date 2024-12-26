namespace leetcode_sharp;

// 494. Target Sum
// https://leetcode.com/problems/target-sum
public class S00494
{
    private int[] _nums = null!;

    public int FindTargetSumWays(int[] nums, int target)
    {
        _nums = nums;
        return Dp(target, nums.Length - 1, 0);
    }

    private int Dp(int target, int index, int currSum)
    {
        switch (index)
        {
            case < 0 when currSum == target:
                return 1;
            case < 0:
                return 0;
        }

        var positive = Dp(target, index - 1, currSum + _nums[index]);
        var negative = Dp(target, index - 1, currSum - _nums[index]);

        return positive + negative;
    }
}
