namespace leetcode_sharp;

// 747. Largest Number At Least Twice of Others
// https://leetcode.com/problems/largest-number-at-least-twice-of-others/
public class S00747
{
    public int DominantIndex(int[] nums)
    {
        var max = 0;
        var maxIndex = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] > max)
            {
                max = nums[i];
                maxIndex = i;
            }
        }

        for (var i = 0; i < nums.Length; i++)
        {
            if (i != maxIndex && nums[i] * 2 > max)
            {
                return -1;
            }
        }

        return maxIndex;
    }
}