using System.Numerics;

namespace leetcode_sharp;

// 3226. Number of Bit Changes to Make Two Integers Equal
// https://leetcode.com/problems/number-of-bit-changes-to-make-two-integers-equal
public class S03226
{
    public int MinChanges(int n, int k)
    {
        return (n & k) != k ? -1 : BitOperations.PopCount((uint)(n - k));
    }
}