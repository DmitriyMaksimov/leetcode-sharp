namespace leetcode_sharp;

// 2460. Apply Operations to an Array
// https://leetcode.com/problems/apply-operations-to-an-array/
public class S02460
{
    public int[] ApplyOperations(int[] nums)
    {
        var n = nums.Length;
        var lastNonZeroFoundAt = 0;

        // Check each element in array
        for (var i = 0; i < n - 1; i++)
        {
            // If it's not zero and equal to next, double the value and zero the next
            if (nums[i] != 0 && nums[i] == nums[i + 1])
            {
                nums[lastNonZeroFoundAt++] = nums[i] * 2;
                nums[i + 1] = 0;
            }
            else if (nums[i] != 0)
            {
                nums[lastNonZeroFoundAt++] = nums[i];
            }
        }

        // If last element is not zero
        if (nums[n - 1] != 0)
        {
            nums[lastNonZeroFoundAt++] = nums[n - 1];
        }

        // Move all 0's to the end
        while (lastNonZeroFoundAt < n)
        {
            nums[lastNonZeroFoundAt++] = 0;
        }

        return nums;
    }
}