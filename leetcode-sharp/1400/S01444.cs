namespace leetcode_sharp;

// 1444. Number of Ways of Cutting a Pizza
// https://leetcode.com/problems/number-of-ways-of-cutting-a-pizza/
public class S01444
{
    private const int KMod = 1_000_000_007;
    private int[,,] _dp = null!;
    private int[,] _prefixSums = null!;
    private int _m;
    private int _n;

    public int Ways(string[] pizza, int k)
    {
        _m = pizza.Length;
        _n = pizza[0].Length;

        initDp(k);
        initPrefixSums(pizza);

        return ways(0, 0, k - 1);
    }

    private void initPrefixSums(IReadOnlyList<string> pizza)
    {
        _prefixSums = new int[_m + 1, _n + 1];

        for (var i = 0; i < _m; ++i)
        {
            for (var j = 0; j < _n; ++j)
            {
                _prefixSums[i + 1, j + 1] = (pizza[i][j] == 'A' ? 1 : 0) + _prefixSums[i, j + 1] + _prefixSums[i + 1, j] - _prefixSums[i, j];
            }
        }
    }

    private void initDp(int k)
    {
        _dp = new int[_m, _n, k];

        for (var i = 0; i < _m; i++)
        {
            for (var j = 0; j < _n; j++)
            {
                for (var l = 0; l < k; l++)
                {
                    _dp[i, j, l] = -1;
                }
            }
        }
    }

    private int ways(int m, int n, int k)
    {
        if (k == 0)
        {
            return 1;
        }

        if (_dp[m, n, k] != -1)
        {
            return _dp[m, n, k];
        }

        _dp[m, n, k] = 0;

        // Horizontal cut
        for (var i = m + 1; i < _m; ++i)
        {
            if (hasApple(m, i, n, _n) && hasApple(i, _m, n, _n))
            {
                _dp[m, n, k] = (_dp[m, n, k] + ways(i, n, k - 1)) % KMod;
            }
        }

        // Vertical cut
        for (var j = n + 1; j < _n; ++j)
        {
            if (hasApple(m, _m, n, j) && hasApple(m, _m, j, _n))
            {
                _dp[m, n, k] = (_dp[m, n, k] + ways(m, j, k - 1)) % KMod;
            }
        }

        return _dp[m, n, k];
    }

    private bool hasApple(int row1, int row2, int col1, int col2)
    {
        return _prefixSums[row2, col2] - _prefixSums[row1, col2] - _prefixSums[row2, col1] + _prefixSums[row1, col1] > 0;
    }
}