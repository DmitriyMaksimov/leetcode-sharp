namespace leetcode_sharp;

// 718. Maximum Length of Repeated Subarray
// https://leetcode.com/problems/maximum-length-of-repeated-subarray
public class S00718
{
    public int FindLength(int[] nums1, int[] nums2)
    {
        var m = nums1.Length;
        var n = nums2.Length;
        var result = 0;

        var dp = new int[m + 1, n + 1];

        for (var i = 0; i <= m; i++)
        {
            for (var j = 0; j <= n; j++)
            {
                if (i == 0 || j == 0)
                {
                    dp[i, j] = 0;
                }
                else if (nums1[i - 1] == nums2[j - 1])
                {
                    dp[i, j] = 1 + dp[i - 1, j - 1];
                    result = Math.Max(result, dp[i, j]);
                }
            }
        }

        return result;
    }
}
