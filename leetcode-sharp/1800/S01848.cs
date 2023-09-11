namespace leetcode_sharp;

// 1848. Minimum Distance to the Target Element
// https://leetcode.com/problems/minimum-distance-to-the-target-element/
public class S01848
{
    public int GetMinDistance(int[] nums, int target, int start)
    {
        var min = int.MaxValue;

        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] == target)
            {
                min = Math.Min(min, Math.Abs(i - start));
            }
        }

        return min;
    }
}