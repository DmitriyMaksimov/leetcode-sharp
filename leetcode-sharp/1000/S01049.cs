namespace leetcode_sharp;

// 1049. Last Stone Weight II
// https://leetcode.com/problems/last-stone-weight-ii
public class S01049
{
    public int LastStoneWeightII(int[] stones)
    {
        var sum = stones.Sum();
        var s2 = 0;

        var n = stones.Length;

        var dp = new bool[sum + 1, n + 1];

        for (var i = 0; i <= n; i++)
        {
            dp[0, i] = true;
        }

        for (var i = 1; i <= n; i++)
        {
            for (var s = 1; s <= sum / 2; s++)
            {
                if (dp[s, i - 1] || (s >= stones[i - 1] && dp[s - stones[i - 1], i - 1]))
                {
                    dp[s, i] = true;
                    s2 = Math.Max(s2, s);
                }
            }
        }

        return sum - 2 * s2;
    }
}
