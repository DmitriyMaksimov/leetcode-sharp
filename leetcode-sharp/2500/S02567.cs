namespace leetcode_sharp;

// 2567. Minimum Score by Changing Two Elements
// https://leetcode.com/problems/minimum-score-by-changing-two-elements
public class S02567
{
    public int MinimizeSum(int[] nums)
    {
        Array.Sort(nums);
        var n = nums.Length;
        return Math.Min(
            nums[n - 1] - nums[2],
            Math.Min(
                nums[n - 2] - nums[1],
                nums[n - 3] - nums[0]
            )
        );
    }
}
