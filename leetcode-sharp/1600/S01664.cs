namespace leetcode_sharp;

// 1664. Ways to Make a Fair Array
// https://leetcode.com/problems/ways-to-make-a-fair-array
public class S01664
{
    public int WaysToMakeFair(int[] nums)
    {
        var result = 0;
        var n = nums.Length;
        var left = new int[2];
        var right = new int[2];

        for (var i = 0; i < n; i++)
        {
            right[i % 2] += nums[i];
        }

        for (var i = 0; i < n; i++)
        {
            right[i % 2] -= nums[i];
            if (left[0] + right[1] == left[1] + right[0])
            {
                result++;
            }

            left[i % 2] += nums[i];
        }

        return result;
    }
}
