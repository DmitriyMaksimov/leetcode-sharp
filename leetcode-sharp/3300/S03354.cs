namespace leetcode_sharp;

// 3354. Make Array Elements Equal to Zero
// https://leetcode.com/problems/make-array-elements-equal-to-zero
public class S03354
{
    public int CountValidSelections(int[] nums)
    {
        var left = 0;
        var result = 0;
        var right = nums.Sum();

        foreach (var num in nums)
        {
            if (num > 0)
            {
                left += num;
                right -= num;
            }
            else
            {
                if (0 <= right - left && right - left <= 1)
                {
                    result++;
                }

                if (0 <= left - right && left - right <= 1)
                {
                    result++;
                }
            }
        }

        return result;
    }
}
