namespace leetcode_sharp;

// 474. Ones and Zeroes
// https://leetcode.com/problems/ones-and-zeroes
public class S00474
{
    public int FindMaxForm(string[] strs, int m, int n)
    {
        var dp = new int[m + 1, n + 1];

        foreach (var str in strs)
        {
            var zeros = 0;
            var ones = 0;

            foreach (var c in str)
            {
                if (c == '0') zeros++;
                else ones++;
            }

            for (var i = m; i >= zeros; i--)
            {
                for (var j = n; j >= ones; j--)
                {
                    dp[i, j] = Math.Max(dp[i, j], dp[i - zeros, j - ones] + 1);
                }
            }
        }

        return dp[m, n];
    }
}
