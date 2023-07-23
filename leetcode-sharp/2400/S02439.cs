namespace leetcode_sharp;

// 2439. Minimize Maximum of Array
// https://leetcode.com/problems/minimize-maximum-of-array/
public class S02439
{
    public int MinimizeArrayValue(int[] nums)
    {
        var sum = 0L;
        var result = 0L;

        for (var i = 0; i < nums.Length; ++i)
        {
            sum += nums[i];
            result = Math.Max(result, (sum + i) / (i + 1));
        }

        return (int)result;
    }
}