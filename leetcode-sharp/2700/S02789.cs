namespace leetcode_sharp;

// 2789. Largest Element in an Array after Merge Operations
// https://leetcode.com/problems/largest-element-in-an-array-after-merge-operations
public class S02789
{
    public long MaxArrayValue(int[] nums)
    {
        var result = 0L;

        for (var i = nums.Length - 1; i >= 0; i--)
        {
            if (nums[i] <= result)
            {
                result += nums[i];
            }
            else
            {
                result = nums[i];
            }
        }

        return result;
    }
}