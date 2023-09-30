namespace leetcode_sharp;

// 2529. Maximum Count of Positive Integer and Negative Integer
// https://leetcode.com/problems/maximum-count-of-positive-integer-and-negative-integer
public class S02529
{
    public int MaximumCount(int[] nums)
    {
        var negativeCount = 0;
        var positiveCount = 0;
        
        foreach (var num in nums)
        {
            if (num > 0)
            {
                ++positiveCount;
            }
            else if (num < 0)
            {
                ++negativeCount;
            }
        }

        return Math.Max(positiveCount, negativeCount);
    }
}