namespace leetcode_sharp;

// 2523. Closest Prime Numbers in Range
// https://leetcode.com/problems/closest-prime-numbers-in-range
public class S02523
{
    public int[] ClosestPrimes(int left, int right)
    {
        var isPrime = Enumerable.Repeat(true, right + 1).ToArray();
        isPrime[1] = false;
        List<int> primes = [];

        for (var num = 2; num * num <= right; num++)
        {
            if (isPrime[num])
            {
                for (var j = num * num; j <= right; j += num)
                {
                    isPrime[j] = false;
                }
            }
        }

        for (var i = left; i <= right; i++)
        {
            if (isPrime[i])
                primes.Add(i);
        }

        var mnDiff = int.MaxValue;
        var leftResult = -1;
        var rightResult = -1;

        for (var i = 0; primes.Count > 0 && i < primes.Count - 1; i++)
        {
            var diff = primes[i + 1] - primes[i];
            if (diff < mnDiff)
            {
                mnDiff = diff;
                leftResult = primes[i];
                rightResult = primes[i + 1];
            }
            else if (diff == mnDiff)
            {
                leftResult = Math.Min(leftResult, primes[i]);
            }
        }

        return leftResult != -1 && rightResult != -1 ? [leftResult, rightResult] : [-1, -1];
    }
}
