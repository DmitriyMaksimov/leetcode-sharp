namespace leetcode_sharp;

// 198. House Robber
// https://leetcode.com/problems/house-robber/description/
public class S00198
{
    private int[] _memo;
    
    public int Rob(int[] nums)
    {
        _memo = new int[nums.Length];
        for (var i = 0; i < _memo.Length; i++)
        {
            _memo[i] = -1;
        }
        
        return findMax(nums, 0);
    }

    private int findMax(IReadOnlyList<int> nums, int index)
    {
        if (index == nums.Count - 1)
        {
            return nums[index];
        }

        if (index >= nums.Count)
        {
            return 0;
        }

        if (_memo[index] >= 0)
        {
            return _memo[index];
        }

        _memo[index] = Math.Max(nums[index] + findMax(nums, index + 2), findMax(nums, index + 1));

        return _memo[index];
    }
}