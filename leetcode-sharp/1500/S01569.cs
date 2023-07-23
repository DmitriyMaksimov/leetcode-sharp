namespace leetcode_sharp;

// 1569. Number of Ways to Reorder Array to Get Same BST
// https://leetcode.com/problems/number-of-ways-to-reorder-array-to-get-same-bst/
public class S01569
{
    private const int Mod = 1000000007;

    public int NumOfWays(int[] nums)
    {
        return countWays(nums.ToList()) - 1;
    }

    private static int countWays(IReadOnlyList<int> nums)
    {
        if (nums.Count <= 2)
        {
            return 1;
        }

        var left = new List<int>();
        var right = new List<int>();
        var root = nums[0];

        for (var i = 1; i < nums.Count; i++)
        {
            if (nums[i] < root)
            {
                left.Add(nums[i]);
            }
            else
            {
                right.Add(nums[i]);
            }
        }

        long leftCount = countWays(left);
        long rightCount = countWays(right);

        return (int) (calculateCombinations(nums.Count - 1, left.Count) % Mod * (leftCount % Mod) % Mod * (rightCount % Mod) % Mod);
    }

    private static long calculateCombinations(int n, int k)
    {
        var dp = new long[n + 1, k + 1];

        for (var i = 0; i <= n; i++)
        {
            dp[i, 0] = 1;
            for (var j = 1; j <= Math.Min(i, k); j++)
            {
                dp[i, j] = (dp[i - 1, j - 1] + dp[i - 1, j]) % Mod;
            }
        }

        return dp[n, k];
    }
}