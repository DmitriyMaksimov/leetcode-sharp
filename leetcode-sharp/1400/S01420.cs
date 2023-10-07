namespace leetcode_sharp;

// 1420. Build Array Where You Can Find The Maximum Exactly K Comparisons
// https://leetcode.com/problems/build-array-where-you-can-find-the-maximum-exactly-k-comparisons/description
public class S01420
{
    public int NumOfArrays(int n, int m, int k)
    {
        const int mod = 1_000_000_007;

        var dp = new int[m + 1][];
        var prefix = new int[m + 1][];
        var prevDp = new int[m + 1][];
        var prevPrefix = new int[m + 1][];

        for (var i = 0; i <= m; i++)
        {
            dp[i] = new int[k + 1];
            prefix[i] = new int[k + 1];
            prevDp[i] = new int[k + 1];
            prevPrefix[i] = new int[k + 1];
        }

        for (var j = 1; j <= m; j++)
        {
            prevDp[j][1] = 1;
            prevPrefix[j][1] = j;
        }

        for (var i = 2; i <= n; i++)
        {
            for (var maxNum = 1; maxNum <= m; maxNum++)
            {
                for (var cost = 1; cost <= k; cost++)
                {
                    dp[maxNum][cost] = (int) ((long) maxNum * prevDp[maxNum][cost] % mod);

                    if (maxNum > 1 && cost > 1)
                    {
                        dp[maxNum][cost] = (dp[maxNum][cost] + prevPrefix[maxNum - 1][cost - 1]) % mod;
                    }

                    prefix[maxNum][cost] = (prefix[maxNum - 1][cost] + dp[maxNum][cost]) % mod;
                }
            }

            for (var j = 1; j <= m; j++)
            {
                Array.Copy(dp[j], prevDp[j], k + 1);
                Array.Copy(prefix[j], prevPrefix[j], k + 1);
            }
        }

        return prefix[m][k];
    }
}