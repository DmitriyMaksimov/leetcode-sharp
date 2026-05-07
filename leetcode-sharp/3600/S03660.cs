namespace leetcode_sharp;

// 3660. Jump Game IX
// https://leetcode.com/problems/jump-game-ix
public class S03660
{
    public int[] MaxValue(int[] nums)
    {
        var n = nums.Length;
        var pre = new int[n];
        var suffixMin = new int[n];
        var result = new int[n];

        pre[0] = nums[0];

        for (var i = 1; i < n; i++)
        {
            pre[i] = Math.Max(nums[i], pre[i - 1]);
        }

        suffixMin[n - 1] = nums[n - 1];
        for (var i = n - 2; i >= 0; i--)
        {
            suffixMin[i] = Math.Min(nums[i], suffixMin[i + 1]);
        }

        result[n - 1] = pre[n - 1];

        for (var i = n - 2; i >= 0; i--)
        {
            result[i] = pre[i];

            if (pre[i] > suffixMin[i + 1])
            {
                result[i] = result[i + 1];
            }
        }

        return result;
    }
}