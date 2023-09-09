namespace leetcode_sharp;

// 1413. Minimum Value to Get Positive Step by Step Sum
// https://leetcode.com/problems/minimum-value-to-get-positive-step-by-step-sum/
public class S01413
{
    public int MinStartValue(int[] nums)
    {
        var min = 0;
        var sum = 0;

        foreach (var num in nums)
        {
            sum += num;
            min = Math.Min(min, sum);
        }

        return 1 - min;
    }
}