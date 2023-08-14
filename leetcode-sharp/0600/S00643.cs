namespace leetcode_sharp;

// 643. Maximum Average Subarray I
// https://leetcode.com/problems/maximum-average-subarray-i/
public class S00643
{
    public double FindMaxAverage(int[] nums, int k)
    {
        var n = nums.Length;
        var sum = new int[n + 1];
        sum[0] = 0;

        for (var i = 1; i <= n; i++)
        {
            sum[i] = sum[i - 1] + nums[i - 1];
        }

        var max = double.MinValue;

        for (int i = k, j = 0; i <= n; i++, j++)
        {
            max = Math.Max(max, (double) (sum[i] - sum[j]) / k);
        }

        return max;
    }
}