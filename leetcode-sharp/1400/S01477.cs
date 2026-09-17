namespace leetcode_sharp;

// 1477. Find Two Non-overlapping Sub-arrays Each With Target Sum
// https://leetcode.com/problems/find-two-non-overlapping-sub-arrays-each-with-target-sum
public class S01477
{
    public int MinSumOfLengths(int[] arr, int target)
    {
        var n = arr.Length;
        var result = n + 1;
        var total = 0;
        var i = 0;
        var dp = Enumerable.Repeat(n, n + 1).ToArray();

        for (var j = 0; j < n; j++)
        {
            total += arr[j];

            while (total > target)
            {
                total -= arr[i];
                i++;
            }

            dp[j + 1] = dp[j];

            if (total == target)
            {
                var len = j - i + 1;

                result = Math.Min(result, len + dp[i]);
                dp[j + 1] = Math.Min(dp[j], len);
            }
        }

        return result == n + 1 ? -1 : result;
    }
}