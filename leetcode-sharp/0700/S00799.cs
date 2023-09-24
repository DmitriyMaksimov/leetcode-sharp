namespace leetcode_sharp;

// 799. Champagne Tower
// https://leetcode.com/problems/champagne-tower/
public class S00799
{
    public double ChampagneTower(int poured, int queryRow, int queryGlass)
    {
        var dp = new double[101, 101];
        dp[0, 0] = poured;

        for (var i = 0; i <= queryRow; i++)
        {
            for (var j = 0; j <= i; j++)
            {
                var q = (dp[i, j] - 1.0) / 2.0;
                if (q > 0)
                {
                    dp[i + 1, j] += q;
                    dp[i + 1, j + 1] += q;
                }
            }
        }

        return Math.Min(1, dp[queryRow, queryGlass]);
    }
}