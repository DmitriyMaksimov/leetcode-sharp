namespace leetcode_sharp;

// 300. Longest Increasing Subsequence
// https://leetcode.com/problems/longest-increasing-subsequence/
public class S00300
{
    public int LengthOfLIS(int[] nums)
    {
        var dp = new int[nums.Length];
        var len = 0;

        foreach (var x in nums)
        {
            var i = Array.BinarySearch(dp, 0, len, x);
            
            if (i < 0)
            {
                i = ~i;
            }

            dp[i] = x;

            if (i == len)
            {
                len++;
            }
        }

        return len;
    }
}