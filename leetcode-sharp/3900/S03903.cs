namespace leetcode_sharp;

// 3903. Smallest Stable Index I
// https://leetcode.com/problems/smallest-stable-index-i
public class S03903
{
    public int FirstStableIndex(int[] nums, int k)
    {
        var n = nums.Length;
        var suffixMin = new int[n];
        suffixMin[n - 1] = nums[n - 1];

        for (var i = n - 2; i >= 0; i--)
        {
            suffixMin[i] = Math.Min(nums[i], suffixMin[i + 1]);
        }

        var prefixMax = nums[0];

        for (var i = 0; i < n; i++)
        {
            prefixMax = Math.Max(prefixMax, nums[i]);

            var instability = prefixMax - suffixMin[i];

            if (instability <= k)
            {
                return i;
            }
        }

        return -1;
    }
}
