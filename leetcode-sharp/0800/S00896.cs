namespace leetcode_sharp;

// 896. Monotonic Array
// https://leetcode.com/problems/monotonic-array/
public class S00896
{
    public bool IsMonotonic(int[] nums)
    {
        var isIncreasing = true;
        var isDecreasing = true;

        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i] > nums[i - 1])
            {
                isDecreasing = false;
            }

            if (nums[i] < nums[i - 1])
            {
                isIncreasing = false;
            }
        }

        return isIncreasing || isDecreasing;
    }
}