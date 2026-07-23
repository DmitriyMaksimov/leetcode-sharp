using System.Numerics;

namespace leetcode_sharp;

// 3513. Number of Unique XOR Triplets I
// https://leetcode.com/problems/number-of-unique-xor-triplets-i
public class S03513
{
    public int UniqueXorTriplets(int[] nums)
    {
        var n = nums.Length;

        if (n < 3)
        {
            return n;
        }

        return (int)BitOperations.RoundUpToPowerOf2((uint)(n + 1));
    }
}