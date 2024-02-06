using System.Numerics;

namespace leetcode_sharp;

// 2997. Minimum Number of Operations to Make Array XOR Equal to K
// https://leetcode.com/problems/minimum-number-of-operations-to-make-array-xor-equal-to-k
public class S02997
{
    public int MinOperations(int[] nums, int k)
    {
        return BitOperations.PopCount((uint) nums.Aggregate(k, (current, num) => current ^ num));
    }
}