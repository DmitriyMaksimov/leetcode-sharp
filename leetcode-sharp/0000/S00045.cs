namespace leetcode_sharp;

// 45. Jump Game II
// https://leetcode.com/problems/jump-game-ii/
public class S00045
{
    private int[] _nums = null!;
    private readonly Dictionary<int, int> _cache = new();

    public int Jump(int[] nums)
    {
        if (nums.Length == 1)
        {
            return 0;
        }
        
        _nums = nums;
        return dp(0);
    }

    private int dp(int index)
    {
        if (index + _nums[index] >= _nums.Length - 1)
        {
            // Can jump to last index
            return _cache[index] = 1;
        }

        if (_nums[index] == 0)
        {
            // We can't move from this index
            return _cache[index] = 100_000;
        }

        if (_cache.TryGetValue(index, out var value))
        {
            return value;
        }

        var retVal = int.MaxValue;
        for (var i = 1; i <= _nums[index]; i++)
        {
            retVal = Math.Min(retVal, dp(index + i) + 1);
        }

        return _cache[index] = retVal;
    }
}