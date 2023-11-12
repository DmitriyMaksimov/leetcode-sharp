namespace leetcode_sharp;

// 2824. Count Pairs Whose Sum is Less than Target
// https://leetcode.com/problems/count-pairs-whose-sum-is-less-than-target
public class S02824
{
    public int CountPairs(IList<int> nums, int target)
    {
        var count = 0;
        var left = 0;
        var right = nums.Count - 1;

        nums = nums.OrderBy(x => x).ToList();

        while (left < right)
        {
            if (nums[left] + nums[right] < target)
            {
                count += right - left;
                ++left;
            }
            else
            {
                --right;
            }
        }

        return count;
    }
}