namespace leetcode_sharp;

// 1043. Partition Array for Maximum Sum
// https://leetcode.com/problems/partition-array-for-maximum-sum
public class S01043
{
    public int MaxSumAfterPartitioning(int[] arr, int k)
    {
        var dp = new int[k + 1];

        for (var start = arr.Length - 1; start >= 0; start--)
        {
            var currMax = 0;
            int end = Math.Min(arr.Length, start + k);

            for (var i = start; i < end; i++)
            {
                currMax = Math.Max(currMax, arr[i]);
                dp[start % (k + 1)] = Math.Max(dp[start % (k + 1)], dp[(i + 1) % (k + 1)] + currMax * (i - start + 1));
            }
        }

        return dp[0];
    }
}