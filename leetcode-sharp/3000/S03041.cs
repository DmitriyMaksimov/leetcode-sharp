namespace leetcode_sharp;

// 3041. Maximize Consecutive Elements in an Array After Modification
// https://leetcode.com/problems/maximize-consecutive-elements-in-an-array-after-modification
public class S03041
{
    public int MaxSelectedElements(int[] nums)
    {
        var dp = new Dictionary<int, int>();

        var result = 0;

        foreach (var num in nums.Order())
        {
            dp[num + 1] = dp.GetValueOrDefault(num, 0) + 1;
            dp[num] = dp.GetValueOrDefault(num - 1, 0) + 1;

            result = Math.Max(result, Math.Max(dp[num], dp[num + 1]));
        }

        return result;
    }
}