namespace leetcode_sharp;

// 377. Combination Sum IV
// https://leetcode.com/problems/combination-sum-iv/
public class S00377
{
    private readonly Dictionary<int, int> _dp = new();
    
    public int CombinationSum4(int[] nums, int target)
    {
        _dp[0] = 1;
        
        return combinationSum4(nums, target);
    }

    private int combinationSum4(int[] nums, int target)
    {
        if (_dp.TryGetValue(target, out var val))
        {
            return val;
        }
        
        return _dp[target] = nums.Where(num => target >= num).Sum(num => CombinationSum4(nums, target - num));
    }
}