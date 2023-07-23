namespace leetcode_sharp;

// 2733. Neither Minimum nor Maximum
// https://leetcode.com/problems/neither-minimum-nor-maximum/
public class S02733
{
    public int FindNonMinOrMax(int[] nums)
    {
        if (nums.Length < 3)
        {
            return -1;
        }

        var a = Math.Min(nums[0], nums[1]);
        var b = Math.Max(nums[0], nums[1]);
        var c = nums[2];

        if (b > c && c > a)
        {
            return c;
        }

        if (c < a)
        {
            return a;
        }

        return b;
    }
}