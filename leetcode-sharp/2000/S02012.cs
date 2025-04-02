namespace leetcode_sharp;

// 2012. Sum of Beauty in the Array
// https://leetcode.com/problems/sum-of-beauty-in-the-array
public class S02012
{
    public int SumOfBeauties(int[] nums)
    {
        var n = nums.Length;
        var minOnRight = new int[n];
        minOnRight[n - 1] = nums[n - 1];

        for (var i = n - 2; i >= 2; i--)
        {
            minOnRight[i] = Math.Min(minOnRight[i + 1], nums[i]);
        }

        var maxOnLeft = nums[0];
        var result = 0;

        for (var i = 1; i < n - 1; i++)
        {
            if (nums[i] > maxOnLeft && nums[i] < minOnRight[i + 1])
            {
                result += 2;
            }
            else if (nums[i] > nums[i - 1] && nums[i] < nums[i + 1])
            {
                result += 1;
            }

            maxOnLeft = Math.Max(nums[i], maxOnLeft);
        }

        return result;
    }
}
