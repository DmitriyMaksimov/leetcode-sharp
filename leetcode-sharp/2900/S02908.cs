namespace leetcode_sharp;

// 2908. Minimum Sum of Mountain Triplets I
// https://leetcode.com/problems/minimum-sum-of-mountain-triplets-i
public class S02908
{
    public int MinimumSum(int[] nums)
    {
        var result = int.MaxValue;

        for (var i = 0; i < nums.Length - 2; i++)
        {
            for (var j = i + 1; j < nums.Length - 1; j++)
            {
                for (var k = j + 1; k < nums.Length; k++)
                {
                    if (nums[i] < nums[j] && nums[k] < nums[j])
                    {
                        result = Math.Min(result, nums[i] + nums[j] + nums[k]);
                    }
                }
            }
        }

        return result == int.MaxValue ? -1 : result;
    }
}