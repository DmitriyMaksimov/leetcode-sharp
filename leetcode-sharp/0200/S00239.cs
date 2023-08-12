namespace leetcode_sharp;

// 239. Sliding Window Maximum
// https://leetcode.com/problems/sliding-window-maximum/
public class S00239
{
    public int[] MaxSlidingWindow(int[] nums, int k)
    {
        var n = nums.Length;
        var result = new int[n - k + 1];

        var left = new int[n];
        var right = new int[n];
        left[0] = nums[0];
        right[n - 1] = nums[n - 1];

        for (var i = 1; i < n; ++i)
        {
            if (i % k == 0) left[i] = nums[i];
            else left[i] = Math.Max(left[i - 1], nums[i]);

            var j = n - i - 1;
            right[j] = j % k == (k - 1) ? nums[j] : Math.Max(right[j + 1], nums[j]);
        }

        for (int i = 0, j = i + k - 1; j < n; ++i, ++j)
        {
            result[i] = Math.Max(right[i], left[j]);
        }

        return result;
    }
}