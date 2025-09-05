using System.Numerics;

namespace leetcode_sharp;

// 2749. Minimum Operations to Make the Integer Zero
// https://leetcode.com/problems/minimum-operations-to-make-the-integer-zero
public class S02749
{
    public int MakeTheIntegerZero(int num1, int num2)
    {
        for (var k = 0; k <= 60; k++)
        {
            var target = num1 - (long)k * num2;

            if (target >= 0 && BitOperations.PopCount((ulong)target) <= k && k <= target)
            {
                return k;
            }
        }

        return -1;
    }
}