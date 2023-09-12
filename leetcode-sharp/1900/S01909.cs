namespace leetcode_sharp;

// 1909. Remove One Element to Make the Array Strictly Increasing
// https://leetcode.com/problems/remove-one-element-to-make-the-array-strictly-increasing/
public class S01909
{
    public bool CanBeIncreasing(int[] nums)
    {
        var count = 0;
        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i] <= nums[i - 1])
            {
                count++;
                if (count > 1)
                {
                    return false;
                }

                if (i > 1 && nums[i] <= nums[i - 2])
                {
                    nums[i] = nums[i - 1];
                }
            }
        }

        return true;
    }
}