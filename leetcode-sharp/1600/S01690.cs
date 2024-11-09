namespace leetcode_sharp;

// 1690. Stone Game VII
// https://leetcode.com/problems/stone-game-vii
public class S01690
{
    public int StoneGameVII(int[] stones)
    {
        var n = stones.Length;
        var dp = new int[n, n];
        var prefixSum = new int[n + 1];

        for (var i = 0; i < n; i++)
        {
            prefixSum[i + 1] = prefixSum[i] + stones[i];
        }

        for (var length = 2; length <= n; length++)
        {
            for (var i = 0; i <= n - length; i++)
            {
                var j = i + length - 1;
                var sum = prefixSum[j + 1] - prefixSum[i];
                dp[i, j] = Math.Max(sum - stones[i] - dp[i + 1, j], sum - stones[j] - dp[i, j - 1]);
            }
        }

        return dp[0, n - 1];
    }
}