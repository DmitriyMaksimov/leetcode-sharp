namespace leetcode_sharp;

// 3349. Adjacent Increasing Subarrays Detection I
// https://leetcode.com/problems/adjacent-increasing-subarrays-detection-i
public class S03349
{
    public bool HasIncreasingSubarrays(IList<int> nums, int k)
    {
        var n = nums.Count;

        if (n < 2 * k)
        {
            return false;
        }

        for (var i = 0; i <= n - 2 * k; i++)
        {
            if (IsStrictlyIncreasing(nums, i, k) && IsStrictlyIncreasing(nums, i + k, k))
            {
                return true;
            }
        }

        return false;
    }

    private static bool IsStrictlyIncreasing(IList<int> nums, int start, int k)
    {
        for (var i = start; i < start + k - 1; i++)
        {
            if (nums[i] >= nums[i + 1])
            {
                return false;
            }
        }

        return true;
    }
}
