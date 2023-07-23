namespace leetcode_sharp;

// 413. Arithmetic Slices
// https://leetcode.com/problems/arithmetic-slices/
public class S00413
{
    public int NumberOfArithmeticSlices(int[] nums)
    {
        var currentCount = 0;
        var result = 0;
        
        for (var i = 2; i < nums.Length; i++)
        {
            if (nums[i] - nums[i - 1] == nums[i - 1] - nums[i - 2])
            {
                currentCount++;
                result += currentCount;
            }
            else
            {
                currentCount = 0;
            }
        }

        return result;
    }
}