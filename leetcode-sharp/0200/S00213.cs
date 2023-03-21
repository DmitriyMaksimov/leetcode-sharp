namespace leetcode_sharp;

// 213. House Robber II
// https://leetcode.com/problems/house-robber-ii/
public class S00213
{
    public int Rob(int[] nums)
    {
        if (nums.Length == 1)
        {
            return nums[0];
        }

        return Math.Max(findMax(nums, 0, nums.Length - 2), findMax(nums, 1, nums.Length - 1));
    }

    private static int findMax(IReadOnlyList<int> nums, int minIndex, int maxIndex)
    {
        var include = 0;
        var exclude = 0;
        
        for (var j = minIndex; j <= maxIndex; j++)
        {
            var i = include;
            var e = exclude;
            include = e + nums[j];
            exclude = Math.Max(e, i);
        }

        return Math.Max(include, exclude);
    }
}