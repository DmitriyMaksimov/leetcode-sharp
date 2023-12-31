namespace leetcode_sharp;

// 2970. Count the Number of Incremovable Subarrays I
// https://leetcode.com/problems/count-the-number-of-incremovable-subarrays-i
public class S02970
{
    public int IncremovableSubarrayCount(int[] nums)
    {
        var n = nums.Length;

        var count = 0;

        for (var i = 0; i < n; i++)
        {
            for (var j = i; j < n; j++)
            {
                count += isIncreasing(nums, i, j, n) ? 1 : 0;
            }
        }

        return count;
    }

    private static bool isIncreasing(IReadOnlyList<int> nums, int start, int end, int n)
    {
        var previous = -1;

        for (var i = 0; i < start; previous = nums[i++])
        {
            if (nums[i] <= previous)
                return false;
        }


        for (var i = end + 1; i < n; previous = nums[i++])
        {
            if (nums[i] <= previous)
                return false;
        }

        return true;
    }
}