namespace leetcode_sharp;

// 523. Continuous Subarray Sum
// https://leetcode.com/problems/continuous-subarray-sum
public class S00523
{
    public bool CheckSubarraySum(int[] nums, int k)
    {
        var map = new Dictionary<int, int?> { [0] = -1 };
        var runningSum = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            runningSum += nums[i];

            if (k != 0)
            {
                runningSum %= k;
            }

            var prev = map.GetValueOrDefault(runningSum);

            if (prev != null)
            {
                if (i - prev > 1)
                {
                    return true;
                }
            }
            else
            {
                map[runningSum] =  i;
            }
        }

        return false;
    }
}