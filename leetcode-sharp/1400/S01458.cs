namespace leetcode_sharp;

// 1458. Max Dot Product of Two Subsequences
// https://leetcode.com/problems/max-dot-product-of-two-subsequences
public class S01458
{
    public int MaxDotProduct(int[] nums1, int[] nums2)
    {
        var len1 = nums1.Length;
        var len2 = nums2.Length;
        var dp = new int[len1][];

        for (var i = 0; i < len1; i++)
        {
            dp[i] = new int[len2];
        }

        for (var i = 0; i < len1; i++)
        {
            for (var j = 0; j < len2; j++)
            {
                dp[i][j] = nums1[i] * nums2[j];
 
                if (i > 0 && j > 0)
                {
                    dp[i][j] += Math.Max(dp[i - 1][j - 1], 0);
                }

                if (i > 0)
                {
                    dp[i][j] = Math.Max(dp[i][j], dp[i - 1][j]);
                }

                if (j > 0)
                {
                    dp[i][j] = Math.Max(dp[i][j], dp[i][j - 1]);
                }
            }
        }

        return dp[len1 - 1][len2 - 1];
    }
}