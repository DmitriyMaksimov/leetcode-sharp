namespace leetcode_sharp;

// 813. Largest Sum of Averages
// https://leetcode.com/problems/largest-sum-of-averages
public class S00813
{
    private double[,] _memo = null!;

    public double LargestSumOfAverages(int[] nums, int k)
    {
        var n = nums.Length;
        _memo = new double[n + 1, n + 1];
        var currentSum = 0.0;

        for (var i = 0; i < n; ++i)
        {
            currentSum += nums[i];
            _memo[i + 1, 1] = currentSum / (i + 1);
        }

        return Search(n, k, nums);
    }

    private double Search(int n, int k, int[] nums)
    {
        if (_memo[n, k] > 0)
        {
            return _memo[n, k];
        }

        if (n < k)
        {
            return 0;
        }

        var currentSum = 0.0;

        for (var i = n - 1; i > 0; --i)
        {
            currentSum += nums[i];
            _memo[n, k] = Math.Max(_memo[n, k], Search(i, k - 1, nums) + currentSum / (n - i));
        }

        return _memo[n, k];
    }
}
