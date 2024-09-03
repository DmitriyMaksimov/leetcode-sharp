namespace leetcode_sharp;

// 3191. Minimum Operations to Make Binary Array Elements Equal to One I
// https://leetcode.com/problems/minimum-operations-to-make-binary-array-elements-equal-to-one-i
public class S03191
{
    public int MinOperations(int[] nums)
    {
        var n = nums.Length;
        var result = 0;

        for (var i = 0; i + 2 < n; ++i)
        {
            if (nums[i] == 0)
            {
                ++result;
                nums[i + 1] = nums[i + 1] == 0 ? 1 : 0;
                nums[i + 2] = nums[i + 2] == 0 ? 1 : 0;
            }
        }

        return nums[n - 1] != 0 && nums[n - 2] != 0 ? result : -1;
    }
}
