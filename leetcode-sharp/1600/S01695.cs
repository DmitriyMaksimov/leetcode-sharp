namespace leetcode_sharp;

// 1695. Maximum Erasure Value
// https://leetcode.com/problems/maximum-erasure-value
public class S01695
{
    public int MaximumUniqueSubarray(int[] nums)
    {
        var set = new HashSet<int>();
        var sum = 0;
        var max = 0;
        var left = 0;

        foreach (var n in nums)
        {
            while (set.Contains(n))
            {
                sum -= nums[left];
                set.Remove(nums[left]);
                left++;
            }

            sum += n;
            set.Add(n);
            max = Math.Max(max, sum);
        }

        return max;
    }
}
