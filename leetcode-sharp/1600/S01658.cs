namespace leetcode_sharp;

// 1658. Minimum Operations to Reduce X to Zero
// https://leetcode.com/problems/minimum-operations-to-reduce-x-to-zero/
public class S01658
{
    public int MinOperations(int[] nums, int x)
    {
        var sum = nums.Sum();

        var target = sum - x;
        if (target == 0)
        {
            return nums.Length;
        }

        var left = 0;
        var right = 0;
        var current = 0;
        var max = -1;

        while (right < nums.Length)
        {
            current += nums[right];
        
            while (current > target && left <= right)
            {
                current -= nums[left];
                left++;
            }

            if (current == target)
            {
                max = Math.Max(max, right - left + 1);
            }

            right++;
        }

        return max == -1 ? -1 : nums.Length - max;
    }
}