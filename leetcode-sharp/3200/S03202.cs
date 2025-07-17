namespace leetcode_sharp;

// 3202. Find the Maximum Length of Valid Subsequence II
// https://leetcode.com/problems/find-the-maximum-length-of-valid-subsequence-ii
public class S03202
{
    public int MaximumLength(int[] nums, int k)
    {
        var dp = new int[k, k];
        var result = 1;

        foreach (var num in nums)
        {
            var currNum = num % k;

            for (var mod = 0; mod < k; mod++)
            {
                var prevNum = (mod - currNum + k) % k;
                dp[currNum, mod] = Math.Max(dp[currNum, mod], 1 + dp[prevNum, mod]);
                result = Math.Max(result, dp[currNum, mod]);
            }
        }

        return result;
    }
}