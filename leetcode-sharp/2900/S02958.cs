namespace leetcode_sharp;

// 2958. Length of Longest Subarray With at Most K Frequency
// https://leetcode.com/problems/length-of-longest-subarray-with-at-most-k-frequency
public class S02958
{
    public int MaxSubarrayLength(int[] nums, int k)
    {
        Dictionary<int, int> count = [];
        var res = 0;
        var i = 0;
        var n = nums.Length;

        for (var j = 0; j < n; ++j)
        {
            count[nums[j]] = count.GetValueOrDefault(nums[j]) + 1;

            while (count[nums[j]] > k)
            {
                count[nums[i]] -= 1;
                ++i;
            }

            res = Math.Max(res, j - i + 1);
        }

        return res;
    }
}