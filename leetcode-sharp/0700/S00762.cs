using System.Numerics;

namespace leetcode_sharp;

// 762. Prime Number of Set Bits in Binary Representation
// https://leetcode.com/problems/prime-number-of-set-bits-in-binary-representation/
public class S00762
{
    public int CountPrimeSetBits(int left, int right)
    {
        var primes = new HashSet<int> {2, 3, 5, 7, 11, 13, 17, 19};
        var count = 0;

        for (var i = left; i <= right; i++)
        {
            if (primes.Contains(BitOperations.PopCount((uint) i)))
            {
                count++;
            }
        }

        return count;
    }
}