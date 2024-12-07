namespace leetcode_sharp;

// 3364. Minimum Positive Sum Subarray
// https://leetcode.com/problems/minimum-positive-sum-subarray
public class S03364
{
    public int MinimumSumSubarray(IList<int> nums, int l, int r)
    {
        var minSum = int.MaxValue;

        for (var size = l; size <= r; size++)
        {
            var currSum = 0;

            for (var i = 0; i < size; i++)
            {
                currSum += nums[i];
            }

            if (currSum > 0)
            {
                minSum = Math.Min(minSum, currSum);
            }

            for (var i = size; i < nums.Count; i++)
            {
                currSum += nums[i] - nums[i - size];

                if (currSum > 0)
                {
                    minSum = Math.Min(minSum, currSum);
                }
            }
        }

        return minSum == int.MaxValue ? -1 : minSum;
    }
}
