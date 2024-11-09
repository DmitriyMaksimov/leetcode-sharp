namespace leetcode_sharp;

// 3115. Maximum Prime Difference
// https://leetcode.com/problems/maximum-prime-difference
public class S03115
{
    private readonly HashSet<int> _primes = [2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97];

    public int MaximumPrimeDifference(int[] nums)
    {
        var firstPrimeIndex = 0;
        var lastPrimeIndex = nums.Length - 1;

        while (!IsPrime(nums[firstPrimeIndex]))
        {
            firstPrimeIndex++;
        }

        while (!IsPrime(nums[lastPrimeIndex]))
        {
            lastPrimeIndex--;
        }

        return lastPrimeIndex - firstPrimeIndex;
    }

    private bool IsPrime(int num)
    {
        return _primes.Contains(num);
    }
}