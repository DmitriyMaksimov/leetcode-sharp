using System.Numerics;

namespace leetcode_sharp;

// 338. Counting Bits
// https://leetcode.com/problems/counting-bits/
public class S00338
{
    public int[] CountBits(int n)
    {
        return Enumerable.Range(0, n + 1).Select(x => BitOperations.PopCount((uint) x)).ToArray();
    }
}