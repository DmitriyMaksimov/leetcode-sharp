namespace leetcode_sharp;

// 3405. Count the Number of Arrays with K Matching Adjacent Elements
// https://leetcode.com/problems/count-the-number-of-arrays-with-k-matching-adjacent-elements
public class S03405
{
    private const int Mod = 1_000_000_007;

    public int CountGoodArrays(int n, int m, int k)
    {
        long result = m;
        result = result * ModPow(m - 1, n - k - 1, Mod) % Mod;
        result = result * Comb(n - 1, k) % Mod;
        return (int)result;
    }

    private long ModPow(long baseVal, long exponent, int mod)
    {
        var result = 1L;
        baseVal %= mod;

        while (exponent > 0)
        {
            if ((exponent & 1) == 1)
            {
                result = result * baseVal % mod;
            }

            baseVal = baseVal * baseVal % mod;
            exponent >>= 1;
        }

        return result;
    }

    private long Comb(int n, int k)
    {
        if (k > n)
        {
            return 0;
        }

        var fact = new long[n + 1];
        fact[0] = 1;
        for (var i = 1; i <= n; i++)
        {
            fact[i] = fact[i - 1] * i % Mod;
        }

        var invK = ModInverse(fact[k], Mod);
        var invNMinusK = ModInverse(fact[n - k], Mod);

        return fact[n] * invK % Mod * invNMinusK % Mod;
    }

    private long ModInverse(long a, int mod)
    {
        return ModPow(a, mod - 2, mod);
    }
}