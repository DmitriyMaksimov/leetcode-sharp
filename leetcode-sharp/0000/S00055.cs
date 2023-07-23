namespace leetcode_sharp;

// 55. Jump Game
// https://leetcode.com/problems/jump-game/
public class S00055
{
    private readonly Dictionary<int, bool> _cache = new();
    
    public bool CanJump(int[] nums)
    {
        return canJump(nums, 0);
    }

    private bool canJump(int[] nums, int index)
    {
        if (index == nums.Length - 1)
        {
            return true;
        }

        if (index >= nums.Length || nums[index] == 0)
        {
            return false;
        }

        if (_cache.TryGetValue(index, out var cachedValue))
        {
            return cachedValue;
        }

        if (index + nums[index] >= nums.Length - 1)
        {
            _cache.Add(index, true);
            return true;
        }

        for (var i = 1; i <= nums[index]; ++i)
        {
            if (canJump(nums, index + i))
            {
                _cache.Add(index, true);
                return true;
            }
        }

        _cache.Add(index, false);
        return false;
    }
}