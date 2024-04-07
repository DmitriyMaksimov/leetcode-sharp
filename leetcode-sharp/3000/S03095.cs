namespace leetcode_sharp;

// 3095. Shortest Subarray With OR at Least K I
// https://leetcode.com/problems/shortest-subarray-with-or-at-least-k-i
public class S03095
{
    public int MinimumSubarrayLength(int[] nums, int k)
    {
        var n = nums.Length;
        var len = n + 1;

        for (var i = 0; i < n; i++)
        {
            var val = 0;

            for (var j = i; j < n; j++)
            {
                val |= nums[j];
                if (val >= k)
                {
                    len = Math.Min(len, j + 1 - i);
                }
            }
        }

        return len == n + 1 ? -1 : len;
    }
}