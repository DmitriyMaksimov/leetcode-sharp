namespace leetcode_sharp;

// 1984. Minimum Difference Between Highest and Lowest of K Scores
// https://leetcode.com/problems/minimum-difference-between-highest-and-lowest-of-k-scores/
public class S01984
{
    public int MinimumDifference(int[] nums, int k)
    {
        Array.Sort(nums);
        
        var min = int.MaxValue;

        for (var i = 0; i <= nums.Length - k; i++)
        {
            min = Math.Min(min, nums[i + k - 1] - nums[i]);
        }

        return min;
    }
}