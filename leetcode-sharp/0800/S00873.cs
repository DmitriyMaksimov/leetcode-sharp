namespace leetcode_sharp;

// 873. Length of Longest Fibonacci Subsequence
// https://leetcode.com/problems/length-of-longest-fibonacci-subsequence
public class S00873
{
    public int LenLongestFibSubseq(int[] arr)
    {
        var n = arr.Length;
        var max = 0;
        var dp = new int[n, n];

        for (var i = 2; i < n; i++)
        {
            var left = 0;
            var right = i - 1;

            while (left < right)
            {
                var sum = arr[left] + arr[right];
                if (sum > arr[i])
                {
                    right--;
                }
                else if (sum < arr[i])
                {
                    left++;
                }
                else
                {
                    dp[right, i] = dp[left, right] + 1;
                    max = Math.Max(max, dp[right, i]);
                    right--;
                    left++;
                }
            }
        }

        return max == 0 ? 0 : max + 2;
    }
}
