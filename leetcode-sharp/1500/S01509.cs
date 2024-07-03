namespace leetcode_sharp;

// 1509. Minimum Difference Between Largest and Smallest Value in Three Moves
// https://leetcode.com/problems/minimum-difference-between-largest-and-smallest-value-in-three-moves
public class S01509
{
    public int MinDifference(int[] nums)
    {
        var n = nums.Length;

        if (n < 5) return 0;

        Array.Sort(nums);

        var result = int.MaxValue;
        
        for (var i = 0; i < 4; ++i)
        {
            result = Math.Min(result, nums[n - 4 + i] - nums[i]);
        }

        return result;
    }
}