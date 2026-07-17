namespace leetcode_sharp;

// 3312. Sorted GCD Pair Queries
// https://leetcode.com/problems/sorted-gcd-pair-queries
public class S03312
{
    public int[] GcdValues(int[] nums, long[] queries)
    {
        var maxValue = nums.Max();

        // divisorCounts[d] = number of input values divisible by d
        var divisorCounts = new int[maxValue + 1];

        foreach (var value in nums)
        {
            for (var divisor = 1; divisor * divisor <= value; divisor++)
            {
                if (value % divisor != 0)
                {
                    continue;
                }

                divisorCounts[divisor]++;

                var otherDivisor = value / divisor;
                if (otherDivisor != divisor)
                {
                    divisorCounts[otherDivisor]++;
                }
            }
        }

        // gcdPairCounts[g] = number of pairs whose GCD is exactly g
        var gcdPairCounts = new long[maxValue + 1];

        for (var gcd = maxValue; gcd >= 1; gcd--)
        {
            long count = divisorCounts[gcd];
            var pairs = count * (count - 1) / 2;

            for (var multiple = gcd * 2; multiple <= maxValue; multiple += gcd)
            {
                pairs -= gcdPairCounts[multiple];
            }

            gcdPairCounts[gcd] = pairs;
        }

        // Prefix sums of pair counts
        var prefixCounts = new long[maxValue + 1];

        for (var gcd = 1; gcd <= maxValue; gcd++)
        {
            prefixCounts[gcd] = prefixCounts[gcd - 1] + gcdPairCounts[gcd];
        }

        var result = new int[queries.Length];

        for (var i = 0; i < queries.Length; i++)
        {
            var query = queries[i];

            var left = 1;
            var right = maxValue;
            var answer = -1;

            while (left <= right)
            {
                var mid = left + ((right - left) / 2);

                if (prefixCounts[mid] > query)
                {
                    answer = mid;
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }

            result[i] = answer;
        }

        return result;
    }
}