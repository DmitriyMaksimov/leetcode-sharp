namespace leetcode_sharp;

// 879. Profitable Schemes
// https://leetcode.com/problems/profitable-schemes/
public class S00879
{
    public int ProfitableSchemes(int n, int minProfit, int[] group, int[] profit)
    {
        const int mod = 1_000_000_007;

        var dp = new int[minProfit + 1, n + 1];
        dp[0, 0] = 1;
        
        for (var k = 0; k < group.Length; k++)
        {
            var g = group[k];
            var p = profit[k];
            
            for (var i = minProfit; i >= 0; i--)
            {
                for (var j = n - g; j >= 0; j--)
                {
                    dp[Math.Min(i + p, minProfit), j + g] = (dp[Math.Min(i + p, minProfit), j + g] + dp[i, j]) % mod;
                }
            }
        }

        var res = 0;

        for (var i = 0; i <= n; i++)
        {
            res += dp[minProfit, i];
            res %= mod;
        }

        return res;
    }
}