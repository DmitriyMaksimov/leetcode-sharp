namespace leetcode_sharp;

// 1175. Prime Arrangements
// https://leetcode.com/problems/prime-arrangements/
public class S01175
{
    public int NumPrimeArrangements(int n)
    {
        const int modulo = 1000000007;

        var primeCount = 0;

        for (var i = 2; i <= n; i++)
        {
            if (isPrime(i))
            {
                primeCount++;
            }
        }

        var nonPrimeCount = n - primeCount;
        var result = 1L;

        for (var i = 1; i <= primeCount; i++)
        {
            result *= i;
            result %= modulo;
        }

        for (var i = 1; i <= nonPrimeCount; i++)
        {
            result *= i;
            result %= modulo;
        }

        return (int) result;
    }

    private static bool isPrime(int n)
    {
        if (n == 2)
        {
            return true;
        }

        if (n % 2 == 0)
        {
            return false;
        }

        for (var i = 3; i <= Math.Sqrt(n); i += 2)
        {
            if (n % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}