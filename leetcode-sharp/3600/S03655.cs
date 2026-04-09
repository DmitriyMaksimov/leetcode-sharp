namespace leetcode_sharp;

// 3655. XOR After Range Multiplication Queries II
// https://leetcode.com/problems/xor-after-range-multiplication-queries-ii
public class S03655
{
    private const int Mod = 1_000_000_007;

    private static long ModPow(long baseValue, long exponent)
    {
        var result = 1L;
        baseValue %= Mod;

        while (exponent > 0)
        {
            if ((exponent & 1) == 1)
            {
                result = result * baseValue % Mod;
            }

            baseValue = baseValue * baseValue % Mod;
            exponent >>= 1;
        }

        return result;
    }

    public int XorAfterQueries(int[] nums, int[][] queries)
    {
        var length = nums.Length;
        var threshold = (int)Math.Sqrt(length);

        var smallStepQueries = new Dictionary<int, List<int[]>>();

        foreach (var query in queries)
        {
            var left = query[0];
            var right = query[1];
            var step = query[2];
            var multiplier = query[3];

            if (step >= threshold)
            {
                for (var index = left; index <= right; index += step)
                {
                    nums[index] = (int)(nums[index] * 1L * multiplier % Mod);
                }
            }
            else
            {
                if (!smallStepQueries.TryGetValue(step, out var list))
                {
                    list = new List<int[]>();
                    smallStepQueries[step] = list;
                }

                list.Add(query);
            }
        }

        foreach (var (step, groupedQueries) in smallStepQueries)
        {
            var multipliers = Enumerable.Repeat(1L, length).ToArray();

            foreach (var query in groupedQueries)
            {
                var left = query[0];
                var right = query[1];
                var multiplier = query[3];

                multipliers[left] = multipliers[left] * multiplier % Mod;

                var stepsCount = (right - left) / step;
                var nextIndex = left + (stepsCount + 1) * step;

                if (nextIndex < length)
                {
                    var inverse = ModPow(multiplier, Mod - 2);
                    multipliers[nextIndex] = multipliers[nextIndex] * inverse % Mod;
                }
            }

            for (var index = 0; index < length; index++)
            {
                if (index >= step)
                {
                    multipliers[index] = multipliers[index] * multipliers[index - step] % Mod;
                }

                nums[index] = (int)(nums[index] * multipliers[index] % Mod);
            }
        }

        return nums.Aggregate(0, (current, value) => current ^ value);
    }
}