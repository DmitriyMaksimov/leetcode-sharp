namespace leetcode_sharp;

// 1646. Get Maximum in Generated Array
// https://leetcode.com/problems/get-maximum-in-generated-array/
public class S01646
{
    public int GetMaximumGenerated(int n)
    {
        if (n == 0)
        {
            return 0;
        }

        var nums = new int[n + 1];
        nums[1] = 1;
        var max = 1;

        for (var i = 2; i <= n; i++)
        {
            nums[i] = nums[i / 2] + i % 2 * nums[i / 2 + 1];
            max = Math.Max(max, nums[i]);
        }

        return max;
    }
}