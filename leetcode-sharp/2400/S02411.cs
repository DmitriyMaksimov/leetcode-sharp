namespace leetcode_sharp;

// 2411. Smallest Subarrays With Maximum Bitwise OR
// https://leetcode.com/problems/smallest-subarrays-with-maximum-bitwise-or
public class S02411
{
    public int[] SmallestSubarrays(int[] nums)
    {
        const int bitWidth = 32;
        var n = nums.Length;

        var nearest = Enumerable.Repeat(-1, bitWidth).ToArray();
        var result = new int[n];

        for (var i = n - 1; i >= 0; i--)
        {
            for (var bit = 0; bit < bitWidth; bit++)
            {
                if ((nums[i] & (1 << bit)) != 0)
                {
                    nearest[bit] = i;
                }
            }

            var lastSetBit = i;

            for (var bit = 0; bit < bitWidth; bit++)
            {
                if (nearest[bit] != -1)
                {
                    lastSetBit = Math.Max(lastSetBit, nearest[bit]);
                }
            }

            result[i] = lastSetBit - i + 1;
        }

        return result;
    }
}