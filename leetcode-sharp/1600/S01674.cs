namespace leetcode_sharp;

// 1674. Minimum Moves to Make Array Complementary
// https://leetcode.com/problems/minimum-moves-to-make-array-complementary
public class S01674
{
    public int MinMoves(int[] nums, int limit)
    {
        var n = nums.Length;
        var diff = new int[2 * limit + 2];

        for (var i = 0; i < n / 2; i++)
        {
            var min = Math.Min(nums[i], nums[n - 1 - i]);
            var max = Math.Max(nums[i], nums[n - 1 - i]);

            diff[2] += 2;
            diff[min + 1] -= 1;
            diff[min + max] -= 1;
            diff[min + max + 1] += 1;
            diff[max + limit + 1] += 1;
        }

        var result = n;
        var currentOps = 0;

        for (var c = 2; c <= 2 * limit; c++)
        {
            currentOps += diff[c];
            result = Math.Min(result, currentOps);
        }

        return result;
    }
}