namespace leetcode_sharp;

// 2275. Largest Combination With Bitwise AND Greater Than Zero
// https://leetcode.com/problems/largest-combination-with-bitwise-and-greater-than-zero
public class S02275
{
    public int LargestCombination(int[] candidates)
    {
        var result = 0;
        var maxElement = candidates.Max();

        for (var b = 1; b <= maxElement; b <<= 1)
        {
            var count = 0;

            foreach (var candidate in candidates)
            {
                count += (candidate & b) > 0 ? 1 : 0;
                result = Math.Max(result, count);
            }
        }

        return result;
    }
}