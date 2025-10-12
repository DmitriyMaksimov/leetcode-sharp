using System.Numerics;

namespace leetcode_sharp;

// 3539. Find Sum of Array Product of Magical Sequences
// https://leetcode.com/problems/find-sum-of-array-product-of-magical-sequences
public class S03539
{
    private const long Mod = 1_000_000_007;
    private readonly Dictionary<(int remaining, int oddNeeded, int index, int carry), long> _memo = new();
    private int[] _numbers = null!;
    
    private long Dfs(int remaining, int oddNeeded, int index, int carry)
    {
        if (remaining < 0 || oddNeeded < 0 || remaining + BitOperations.PopCount((uint)carry) < oddNeeded)
        {
            return 0;
        }

        if (remaining == 0)
        {
            return oddNeeded == BitOperations.PopCount((uint)carry) ? 1 : 0;
        }

        if (index >= _numbers.Length)
        {
            return 0;
        }

        var key = (remaining, oddNeeded, index, carry);
        if (_memo.TryGetValue(key, out var cached))
        {
            return cached;
        }

        long ans = 0;
        var num = _numbers[index];

        for (var take = 0; take <= remaining; take++)
        {
            var ways = Comb(remaining, take) * ModPow(num, take, Mod) % Mod;
            var newCarry = carry + take;

            ans = (ans + ways * Dfs(remaining - take, oddNeeded - newCarry % 2, index + 1, newCarry / 2)) % Mod;
        }

        return _memo[key] = ans;
    }

    private static long ModPow(long baseVal, int exp, long mod)
    {
        long result = 1;
        baseVal %= mod;
        while (exp > 0)
        {
            if ((exp & 1) != 0)
            {
                result = result * baseVal % mod;
            }

            baseVal = baseVal * baseVal % mod;
            exp >>= 1;
        }

        return result;
    }

    private static long Comb(int n, int k)
    {
        if (k < 0 || k > n)
        {
            return 0;
        }

        if (k == 0 || k == n)
        {
            return 1;
        }

        var result = 1L;
        for (var i = 1; i <= k; i++)
        {
            result *= n - (k - i);
            result /= i;
            result %= Mod;
        }

        return result;
    }

    public int MagicalSum(int m, int k, int[] nums)
    {
        _numbers = nums;
        return (int)Dfs(m, k, 0, 0);
    }
}