namespace leetcode_sharp;

// 41. First Missing Positive
// https://leetcode.com/problems/first-missing-positive/
public class S00041
{
    public int FirstMissingPositive(int[] nums)
    {
        for (var i = 0; i < nums.Length;)
        {
            var correct = nums[i] - 1;

            if (nums[i] <= nums.Length && nums[i] > 0 && nums[i] != nums[correct])
            {
                (nums[i], nums[correct]) = (nums[correct], nums[i]);
            }
            else
            {
                i++;
            }
        }

        for (var j = 0; j < nums.Length; j++)
        {
            if (nums[j] != j + 1)
            {
                return j + 1;
            }
        }

        return nums.Length + 1;
    }
}