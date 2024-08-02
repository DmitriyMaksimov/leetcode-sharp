namespace leetcode_sharp;

// 2134. Minimum Swaps to Group All 1's Together II
// https://leetcode.com/problems/minimum-swaps-to-group-all-1s-together-ii
public class S02134
{
    public int MinSwaps(int[] nums)
    {
        var ones = nums.Count(x => x == 1);
        var n = nums.Length;
        var onesInWindow = 0;

        for (int i = 0, x = 0; i < n + ones; i++)
        {
            if (i >= ones && nums[(i - ones) % n] == 1) --x;
            if (nums[i % n] == 1) ++x;

            onesInWindow = Math.Max(x, onesInWindow);
        }

        return ones - onesInWindow;
    }
}
