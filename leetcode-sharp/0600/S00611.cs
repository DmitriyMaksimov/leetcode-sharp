namespace leetcode_sharp;

// 611. Valid Triangle Number
// https://leetcode.com/problems/valid-triangle-number
public class S00611
{
    public int TriangleNumber(int[] nums)
    {
        Array.Sort(nums);

        var result = 0;

        for (var i = nums.Length - 1; i >= 2; i--)
        {
            var left = 0;
            var right = i - 1;

            while (left < right)
            {
                if (nums[left] + nums[right] > nums[i])
                {
                    result += right - left;
                    right--;
                }
                else
                {
                    left++;
                }
            }
        }

        return result;
    }
}
