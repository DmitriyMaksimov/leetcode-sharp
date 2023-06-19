namespace leetcode_sharp;

// 1827. Minimum Operations to Make the Array Increasing
// https://leetcode.com/problems/minimum-operations-to-make-the-array-increasing/
public class S01827
{
    public int MinOperations(int[] nums)
    {
        if (nums.Length < 2)
        {
            return 0;
        }

        var result = 0;

        for (var i = 1; i < nums.Length; i++)
        {
            var operations = Math.Max(nums[i - 1] + 1, nums[i]);
            result += operations - nums[i];  
            nums[i] = operations;
        }

        return result;
    }
}