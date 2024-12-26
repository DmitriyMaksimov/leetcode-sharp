namespace leetcode_sharp;

// 2521. Distinct Prime Factors of Product of Array
// https://leetcode.com/problems/distinct-prime-factors-of-product-of-array
public class S02521
{
    public int DistinctPrimeFactors(int[] nums)
    {
        int[] primeNumbers = [2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97];
        HashSet<int> distinctPrimes = [];

        foreach (var n in nums)
        {
            var num = n;

            foreach (var prime in primeNumbers)
            {
                if (num % prime == 0)
                {
                    distinctPrimes.Add(prime);

                    while (num % prime == 0)
                    {
                        num /= prime;
                    }
                }
            }

            if (num >= 2)
            {
                distinctPrimes.Add(num);
            }
        }

        return distinctPrimes.Count;
    }
}
