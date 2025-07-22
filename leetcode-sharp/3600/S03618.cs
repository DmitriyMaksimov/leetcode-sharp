using System.Collections;

namespace leetcode_sharp;

// 3618. Split Array by Prime Indices
// https://leetcode.com/problems/split-array-by-prime-indices
public class S03618
{
    public long SplitArray(int[] nums)
    {
        var primes = Primes(nums.Length).ToHashSet();
        var sumA = 0L;
        var sumB = 0L;

        for (var i = 0; i < nums.Length; i++)
        {
            if (primes.Contains(i))
            {
                sumA += nums[i];
            }
            else
            {
                sumB += nums[i];
            }
        }

        return Math.Abs(sumA - sumB);
    }

    private static IEnumerable<int> Primes(int upperLimit)
    {
        yield return 2;

        if (upperLimit == 2)
        {
            yield break;
        }

        // Check odd numbers for primality
        const int offset = 3;
        var isPrime = new BitArray(ToIndex(upperLimit) + 1, true);
        var upperSqrtIndex = ToIndex((int)Math.Sqrt(upperLimit));

        for (var i = 0; i <= upperSqrtIndex; i++)
        {
            if (!isPrime[i])
            {
                continue;
            }

            var number = ToNumber(i);
            yield return number;

            // Any multiples of the number are composite and their respective bits should be turned off.
            for (var j = ToIndex(number * number); j > i && j < isPrime.Length; j += number)
            {
                isPrime[j] = false;
            }
        }

        // Output remaining primes once bit array is fully resolved:
        for (var i = upperSqrtIndex + 1; i < isPrime.Length; i++)
        {
            if (isPrime[i])
            {
                yield return ToNumber(i);
            }
        }

        yield break;

        int ToNumber(int index) => 2 * index + offset;
        int ToIndex(int number) => (number - offset) / 2;
    }
}