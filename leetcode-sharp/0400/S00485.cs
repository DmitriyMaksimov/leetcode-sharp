namespace leetcode_sharp;

// 485. Max Consecutive Ones
// https://leetcode.com/problems/max-consecutive-ones/
public class S00485
{
    public int FindMaxConsecutiveOnes(int[] nums)
    {
        var max = 0;
        var current = 0;
        foreach (var num in nums)
        {
            if (num == 1)
            {
                current++;
            }
            else
            {
                max = Math.Max(max, current);
                current = 0;
            }
        }

        return Math.Max(max, current);
    }
}