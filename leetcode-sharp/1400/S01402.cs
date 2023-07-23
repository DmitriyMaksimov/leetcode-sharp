namespace leetcode_sharp;

// 1402. Reducing Dishes
// https://leetcode.com/problems/reducing-dishes/
public class S01402
{
    public int MaxSatisfaction(int[] satisfaction)
    {
        var cumulativeSum = 0;
        var result = 0;
        var current = 0;

        foreach (var sat in satisfaction.OrderByDescending(x => x))
        {
            current += cumulativeSum + sat;
            cumulativeSum += sat;

            result = Math.Max(result, current);
        }

        return result;
    }
}