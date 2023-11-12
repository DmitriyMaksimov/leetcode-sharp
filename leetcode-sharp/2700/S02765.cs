namespace leetcode_sharp;

// 2765. Longest Alternating Subarray
// https://leetcode.com/problems/longest-alternating-subarray
public class S02765
{
    public int AlternatingSubarray(int[] nums)
    {
        var n = nums.Length;
        var res = 0;

        for (var i = 0; i < n; ++i)
        {
            for (var j = i + 1; j < n && nums[j] == nums[i] + (j - i) % 2; ++j)
            {
                res = Math.Max(res, j - i + 1);
            }
        }

        return res > 1 ? res : -1;
    }
}