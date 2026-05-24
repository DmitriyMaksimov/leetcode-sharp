namespace leetcode_sharp;

// 1340. Jump Game V
// https://leetcode.com/problems/jump-game-v
public class S01340
{
    public int MaxJumps(int[] arr, int d)
    {
        var n = arr.Length;
        var dp = new int[n];
        var result = 1;

        for (var i = 0; i < n; ++i)
        {
            result = Math.Max(result, Dfs(arr, n, d, i, dp));
        }

        return result;
    }

    private static int Dfs(int[] arr, int n, int d, int i, int[] dp)
    {
        if (dp[i] != 0)
        {
            return dp[i];
        }

        var result = 1;

        for (var j = i + 1; j <= Math.Min(i + d, n - 1) && arr[j] < arr[i]; ++j)
        {
            result = Math.Max(result, 1 + Dfs(arr, n, d, j, dp));
        }

        for (var j = i - 1; j >= Math.Max(i - d, 0) && arr[j] < arr[i]; --j)
        {
            result = Math.Max(result, 1 + Dfs(arr, n, d, j, dp));
        }

        return dp[i] = result;
    }
}