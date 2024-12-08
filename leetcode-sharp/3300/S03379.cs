namespace leetcode_sharp;

// 3379. Transformed Array
// https://leetcode.com/problems/transformed-array
public class S03379
{
    public int[] ConstructTransformedArray(int[] nums)
    {
        var n = nums.Length;
        var result = new int[n];

        for (var i = 0; i < n; i++)
        {
            var index = nums[i] switch
            {
                > 0 => (i + nums[i]) % n,
                < 0 => (n + i - Math.Abs(nums[i]) % n) % n,
                0 => i
            };

            result[i] = nums[index];
        }

        return result;
    }
}
