namespace leetcode_sharp;

// 908. Smallest Range I
// https://leetcode.com/problems/smallest-range-i
public class S00908
{
    public int SmallestRangeI(int[] nums, int k)
    {
        var min = nums[0];
        var max = nums[0];

        foreach (var num in nums)
        {
            if (num < min)
            {
                min = num;
            }

            if (num > max)
            {
                max = num;
            }
        }

        return Math.Max(0, max - min - 2 * k);
    }
}