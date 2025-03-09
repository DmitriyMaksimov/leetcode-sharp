namespace leetcode_sharp;

// 3452. Sum of Good Numbers
// https://leetcode.com/problems/sum-of-good-numbers
public class S03452
{
    public int SumOfGoodNumbers(int[] nums, int k)
    {
        var result = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            if ((i < k || nums[i - k] < nums[i]) && (i + k > nums.Length - 1 || nums[i + k] < nums[i]))
            {
                result += nums[i];
            }
        }

        return result;
    }
}
