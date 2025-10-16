namespace leetcode_sharp;

// 2598. Smallest Missing Non-negative Integer After Operations
// https://leetcode.com/problems/smallest-missing-non-negative-integer-after-operations
public class S02598
{
    public int FindSmallestInteger(int[] nums, int value)
    {
        var stop = 0;
        var counts = new int[value];

        foreach (var a in nums)
        {
            counts[(a % value + value) % value]++;
        }

        for (var i = 0; i < value; ++i)
        {
            if (counts[i] < counts[stop])
            {
                stop = i;
            }
        }

        return value * counts[stop] + stop;
    }
}