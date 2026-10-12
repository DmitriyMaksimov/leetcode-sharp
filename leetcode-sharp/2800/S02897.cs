namespace leetcode_sharp;

// 2897. Apply Operations on Array to Maximize Sum of Squares
// https://leetcode.com/problems/apply-operations-on-array-to-maximize-sum-of-squares
public class S02897
{
    public int MaxSum(IList<int> nums, int k)
    {
        const long mod = 1_000_000_007;
        const int numberOfBits = 32;

        var bitCounts = new int[numberOfBits];

        foreach (var number in nums)
        {
            for (var bit = 0; bit < numberOfBits; bit++)
            {
                if ((number & (1 << bit)) != 0)
                {
                    bitCounts[bit]++;
                }
            }
        }

        var result = 0L;

        for (var i = 0; i < k; i++)
        {
            var current = 0L;

            for (var bit = 0; bit < numberOfBits; bit++)
            {
                if (bitCounts[bit] > 0)
                {
                    bitCounts[bit]--;
                    current += 1L << bit;
                }
            }

            result = (result + current * current % mod) % mod;
        }

        return (int)result;
    }
}