namespace leetcode_sharp;

// 2909. Minimum Sum of Mountain Triplets II
// https://leetcode.com/problems/minimum-sum-of-mountain-triplets-ii
public class S02909
{
    public int MinimumSum(int[] nums)
    {
        var n = nums.Length;
        var leftToRight = Enumerable.Repeat(int.MaxValue, n).ToArray();
        var rightToLeft = Enumerable.Repeat(int.MaxValue, n).ToArray();

        var minL = nums[0];
        var minR = nums[n - 1];
        var result = int.MaxValue;

        for (var i = 1; i < n; i++)
        {
            minL = Math.Min(minL, nums[i - 1]);
            leftToRight[i] = minL;
        }

        for (var i = n - 2; i >= 0; i--)
        {
            minR = Math.Min(minR, nums[i + 1]);
            rightToLeft[i] = minR;
        }

        for (var i = 1; i < n - 1; i++)
        {
            if (leftToRight[i] < nums[i] && rightToLeft[i] < nums[i])
            {
                result = Math.Min(result, nums[i] + leftToRight[i] + rightToLeft[i]);
            }
        }

        return result == int.MaxValue ? -1 : result;
    }
}
