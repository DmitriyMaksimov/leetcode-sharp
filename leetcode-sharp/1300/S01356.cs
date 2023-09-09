using System.Numerics;

namespace leetcode_sharp;

// 1356. Sort Integers by The Number of 1 Bits
// https://leetcode.com/problems/sort-integers-by-the-number-of-1-bits/
public class S01356
{
    public int[] SortByBits(int[] arr)
    {
        Array.Sort(arr, (a, b) =>
        {
            var aBits = BitOperations.PopCount((uint) a);
            var bBits = BitOperations.PopCount((uint) b);
            return aBits == bBits ? a - b : aBits - bBits;
        });
        return arr;
    }
}