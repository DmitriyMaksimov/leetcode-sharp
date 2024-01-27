namespace leetcode_sharp;

// 629. K Inverse Pairs Array
// https://leetcode.com/problems/k-inverse-pairs-array
public class S00629
{
    private const int Mod = 1000000007;
    private readonly int[,] _dp = new int[1001, 1001];

    public int KInversePairs(int n, int k)
    {
        _dp[0, 0] = 1;

        if (_dp[n, k] != 0)
        {
            return _dp[n, k];
        }

        for (var i = 1; i <= n; ++i)
        {
            for (var j = 0; j <= k; ++j)
            {
                _dp[i, j] = (_dp[i - 1, j] + (j > 0 ? _dp[i, j - 1] : 0)) % Mod;
                if (j >= i)
                {
                    _dp[i, j] = (Mod + _dp[i, j] - _dp[i - 1, j - i]) % Mod;
                }
            }
        }

        return _dp[n, k];
    }
}