namespace leetcode_sharp;

// 2369. Check if There is a Valid Partition For The Array
// https://leetcode.com/problems/check-if-there-is-a-valid-partition-for-the-array/
public class S02369
{
    public bool ValidPartition(int[] nums)
    {
        var n = nums.Length;
        var dp = new bool[n + 1];
        dp[0] = true;

        if (nums[1] == nums[0])
        {
            dp[2] = true;
        }

        for (var i = 2; i < n; i++)
        {
            if (nums[i] == nums[i - 1])
            {
                dp[i + 1] |= dp[i - 1];
            }

            if (nums[i] == nums[i - 1] && nums[i] == nums[i - 2])
            {
                dp[i + 1] |= dp[i - 2];
            }

            if (nums[i] == nums[i - 1] + 1 && nums[i] == nums[i - 2] + 2)
            {
                dp[i + 1] |= dp[i - 2];
            }
        }

        return dp[n];
    }
}