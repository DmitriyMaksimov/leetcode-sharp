namespace leetcode_sharp;

// 2574. Left and Right Sum Differences
// https://leetcode.com/problems/left-and-right-sum-differences/
public class S02574
{
    public int[] LeftRightDifference(int[] nums)
    {
        var leftSum = 0;
        var rightSum = nums.Sum();

        for (var i = 0; i < nums.Length; i++)
        {
            var val = nums[i];
            rightSum -= val;

            nums[i] = Math.Abs(leftSum - rightSum);
            leftSum += val;
        }

        return nums;
    }
}