namespace leetcode_sharp;

// 2338. Count the Number of Ideal Arrays
// https://leetcode.com/problems/count-the-number-of-ideal-arrays
public class S02338
{
    private const int Mod = 1_000_000_007;
    private long[] _factorials = null!;
    private long[] _factInv = null!;

    public int IdealArrays(int n, int maxValue)
    {
        var result = 0L;
        Precompute(n + maxValue);

        for (var i = 1; i <= maxValue; i++)
        {
            var tmp = i;
            var dictionary = new Dictionary<int, int>();

            for (var j = 2; j * j <= tmp; j++)
            {
                while (tmp % j == 0)
                {
                    dictionary[j] = dictionary.GetValueOrDefault(j) + 1;
                    tmp /= j;
                }
            }

            if (tmp > 1)
            {
                dictionary[tmp] = dictionary.GetValueOrDefault(tmp) + 1;
            }

            var gain = 1L;
            foreach (var val in dictionary.Values)
            {
                gain *= Comb(n + val - 1, val);
                gain %= Mod;
            }

            result = (result + gain) % Mod;
        }

        return (int)result;
    }

    private void Precompute(int n)
    {
        var inv = new long[n + 1];
        _factorials = new long[n + 1];
        _factInv = new long[n + 1];

        inv[1] = 1;
        _factorials[0] = _factorials[1] = 1;
        _factInv[0] = _factInv[1] = 1;

        for (var i = 2; i <= n; i++)
        {
            inv[i] = Mod - Mod / i * inv[Mod % i] % Mod;
            _factorials[i] = _factorials[i - 1] * i % Mod;
            _factInv[i] = _factInv[i - 1] * inv[i] % Mod;
        }
    }

    private long Comb(int a, int b)
    {
        return _factorials[a] * _factInv[b] % Mod * _factInv[a - b] % Mod;
    }
}
