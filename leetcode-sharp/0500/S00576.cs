namespace leetcode_sharp;

// 576. Out of Boundary Paths
// https://leetcode.com/problems/out-of-boundary-paths
public class S00576
{
    private int _m;
    private int _n;
    private const int Mod = 1_000_000_007;
    
    public int FindPaths(int m, int n, int maxMove, int startRow, int startColumn)
    {
        var dp = new int[m, n, maxMove + 1];
        for (var i = 0; i < m; i++)
        {
            for (var j = 0; j < n; j++)
            {
                for (var k = 0; k <= maxMove; k++)
                {
                    dp[i, j, k] = -1;
                }
            }
        }

        this._m = m;
        this._n = n;
        return helper(maxMove, startRow, startColumn, dp);
    }

    private int helper(int maxMove, int x, int y, int[,,] dp)
    {
        if (x < 0 || x >= _m || y < 0 || y >= _n) return 1;
        if (maxMove <= 0) return 0;
        if (dp[x, y, maxMove] != -1)
        {
            return dp[x, y, maxMove];
        }

        var res = helper(maxMove - 1, x + 1, y, dp) % Mod;
        res = (res + helper(maxMove - 1, x, y - 1, dp)) % Mod;
        res = (res + helper(maxMove - 1, x - 1, y, dp)) % Mod;
        res = (res + helper(maxMove - 1, x, y + 1, dp)) % Mod;

        dp[x, y, maxMove] = res;

        return res;
    }
}