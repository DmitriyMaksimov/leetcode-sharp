namespace leetcode_sharp;

// 1922. Count Good Numbers
// https://leetcode.com/problems/count-good-numbers
public class S01922
{
    private const long Mod = 1_000_000_007;

    public int CountGoodNumbers(long n)
    {
        var odd = n / 2;
        var even = (n + 1) / 2;
        return (int)(Pow(5, even) * Pow(4, odd) % Mod);
    }

    private static long Pow(long x, long n)
    {
        if (n == 0)
        {
            return 1;
        }

        var temp = Pow(x, n / 2);

        if (n % 2 == 0)
        {
            return temp * temp % Mod;
        }

        return x * temp * temp % Mod;
    }
}
