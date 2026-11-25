using System.Numerics;

namespace leetcode_sharp;

// 3934. Smallest Unique Subarray
// https://leetcode.com/problems/smallest-unique-subarray
public class S03934
{
    public int SmallestUniqueSubarray(int[] nums)
    {
        var n = nums.Length;
        var names = new List<int[]> { nums };

        for (var half = 1; 2 * half <= n; half *= 2)
        {
            var pairs = Pairs(names[^1], half);

            Array.Sort(pairs);

            var uniqueCount = pairs.Where((t, i) => i == 0 || t != pairs[i - 1]).Count();

            var ids = new long[uniqueCount];

            var id = -1;

            for (var i = 0; i < pairs.Length; i++)
            {
                if (i == 0 || pairs[i] != pairs[i - 1])
                {
                    id++;
                    ids[id] = pairs[i];
                }
            }

            var originalPairs = Pairs(names[^1], half);
            var result = new int[originalPairs.Length];

            for (var i = 0; i < originalPairs.Length; i++)
            {
                result[i] = Array.BinarySearch(ids, originalPairs[i]);
            }

            names.Add(result);
        }

        var lo = 1;
        var hi = n;

        while (lo < hi)
        {
            var mid = lo + (hi - lo) / 2;

            if (Found(names, mid))
            {
                hi = mid;
            }
            else
            {
                lo = mid + 1;
            }
        }

        return lo;
    }

    private static bool Found(List<int[]> names, int length)
    {
        var k = BitOperations.Log2((uint)length);

        var pairs = Pairs(names[k], length - (1 << k));

        Array.Sort(pairs);

        for (var i = 0; i < pairs.Length; i++)
        {
            if ((i == 0 || pairs[i - 1] != pairs[i]) && (i + 1 == pairs.Length || pairs[i] != pairs[i + 1]))
            {
                return true;
            }
        }

        return false;
    }

    private static long[] Pairs(int[] block, int shift)
    {
        var pairs = new long[block.Length - shift];

        for (var i = shift; i < block.Length; i++)
        {
            pairs[i - shift] = ((long)block[i - shift] << 32) | (uint)block[i];
        }

        return pairs;
    }
}