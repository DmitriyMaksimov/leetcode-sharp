namespace leetcode_sharp;

// 1546. Maximum Number of Non-Overlapping Subarrays With Sum Equals Target
// https://leetcode.com/problems/maximum-number-of-non-overlapping-subarrays-with-sum-equals-target
public class S01546
{
    public int MaxNonOverlapping(int[] nums, int target)
    {
        var map = new Dictionary<int, int> { [0] = -1 };
        var prefixSum = 0;
        var availableIndex = -1;
        var result = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            prefixSum += nums[i];
            var remain = prefixSum - target;

            if (map.TryGetValue(remain, out var prevIndex) && prevIndex >= availableIndex)
            {
                result++;
                availableIndex = i;
            }

            map[prefixSum] = i;
        }

        return result;
    }
}