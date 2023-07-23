namespace leetcode_sharp;

// 2006. Count Number of Pairs With Absolute Difference K
// https://leetcode.com/problems/count-number-of-pairs-with-absolute-difference-k/
public class S02006
{
    public int CountKDifference(int[] nums, int k)
    {
        var n = nums.Length;
        var result = 0;

        for (var i = 0; i < n; i++)
        {
            for (var j = i + 1; j < n; j++)
            {
                if (Math.Abs(nums[i] - nums[j]) == k)
                {
                    ++result;
                }
            }
        }
        
        return result;
    }
}