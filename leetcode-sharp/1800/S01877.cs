namespace leetcode_sharp;

// 1877. Minimize Maximum Pair Sum in Array
// https://leetcode.com/problems/minimize-maximum-pair-sum-in-array
public class S01877
{
    public int MinPairSum(int[] nums)
    {
        var result = int.MinValue;
        Array.Sort(nums);

        var start = 0;
        var end = nums.Length - 1;

        while (start < end)
        {
            result = Math.Max(result, nums[start++] + nums[end--]);
        }

        return result;
    }
}