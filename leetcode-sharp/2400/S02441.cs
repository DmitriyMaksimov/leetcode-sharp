namespace leetcode_sharp;

// 2441. Largest Positive Integer That Exists With Its Negative
// https://leetcode.com/problems/largest-positive-integer-that-exists-with-its-negative/
public class S02441
{
    public int FindMaxK(int[] nums)
    {
        var max = -1;
        var set = new HashSet<int>();

        foreach (var num in nums)
        {
            if (set.Contains(-num))
            {
                max = Math.Max(max, Math.Abs(num));
            }

            set.Add(num);
        }

        return max;
    }
}