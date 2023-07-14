namespace leetcode_sharp;

// 1218. Longest Arithmetic Subsequence of Given Difference
// https://leetcode.com/problems/longest-arithmetic-subsequence-of-given-difference/
public class S01218
{
    public int LongestSubsequence(int[] arr, int difference)
    {
        var dp = new Dictionary<int, int>();
        var result = 0;

        foreach (var n in arr)
        {
            dp[n] = dp.GetValueOrDefault(n - difference) + 1;
            result = Math.Max(dp[n], result);
        }

        return result;
    }
}