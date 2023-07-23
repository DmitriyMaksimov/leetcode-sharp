namespace leetcode_sharp;

// 2444. Count Subarrays With Fixed Bounds
// https://leetcode.com/problems/count-subarrays-with-fixed-bounds/
public class S02444
{
    public long CountSubarrays(int[] nums, int minK, int maxK)
    {
        var result = 0L;
        var minPosition = -1;
        var maxPosition = -1;
        var leftBound = -1;

        for (var i = 0; i < nums.Length; ++i)
        {
            if (nums[i] < minK || nums[i] > maxK)
            {
                leftBound = i;
            }

            if (nums[i] == minK)
            {
                minPosition = i;
            }

            if (nums[i] == maxK)
            {
                maxPosition = i;
            }

            result += Math.Max(0, Math.Min(maxPosition, minPosition) - leftBound);
        }

        return result;
    }
}