namespace leetcode_sharp;

// 3343. Count Number of Balanced Permutations
// https://leetcode.com/problems/count-number-of-balanced-permutations
public class S03343
{
    private const int Mod = 1_000_000_007;

    private long[] _factorials = null!;
    private long[] _inverses = null!;
    private long[] _inverseFactorials = null!;

    private void Precompute(int n)
    {
        _factorials = new long[n + 1];
        _inverses = new long[n + 1];
        _inverseFactorials = new long[n + 1];

        _factorials[0] = 1;
        _inverses[0] = 1;
        _inverses[1] = 1;
        _inverseFactorials[0] = 1;

        for (var i = 1; i <= n; i++)
        {
            _factorials[i] = _factorials[i - 1] * i % Mod;
        }

        for (var i = 2; i <= n; i++)
        {
            _inverses[i] = Mod - Mod / i * _inverses[Mod % i] % Mod;
        }

        for (var i = 1; i <= n; i++)
        {
            _inverseFactorials[i] = _inverseFactorials[i - 1] * _inverses[i] % Mod;
        }
    }

    public int CountBalancedPermutations(string num)
    {
        var n = num.Length;
        var sum = num.Sum(c => c - '0');
        if (sum % 2 != 0)
        {
            return 0;
        }

        Precompute(n);

        var halfSum = sum / 2;
        var halfLen = n / 2;

        var dp = new int[halfSum + 1, halfLen + 1];
        dp[0, 0] = 1;

        var digits = new int[10];

        foreach (var c in num)
        {
            var d = c - '0';
            digits[d]++;

            for (var i = halfSum; i >= d; i--)
            {
                for (var j = halfLen; j > 0; j--)
                {
                    dp[i, j] = (dp[i, j] + dp[i - d, j - 1]) % Mod;
                }
            }
        }

        long result = dp[halfSum, halfLen];

        result = result * _factorials[halfLen] % Mod * _factorials[n - halfLen] % Mod;

        foreach (var digitCount in digits)
        {
            result = result * _inverseFactorials[digitCount] % Mod;
        }

        return (int)result;
    }
}
