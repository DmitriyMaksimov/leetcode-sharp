namespace leetcode_sharp;

// 2784. Check if Array is Good
// https://leetcode.com/problems/check-if-array-is-good
public class S02784
{
    public bool IsGood(int[] nums)
    {
        Array.Sort(nums);

        for (var i = 0; i < nums.Length; i++)
        {
            if (i < nums.Length - 1)
            {
                if (nums[i] != i + 1)
                {
                    return false;
                }
            }
            else
            {
                if (nums[i] != i)
                {
                    return false;
                }
            }
        }

        return true;
    }
}