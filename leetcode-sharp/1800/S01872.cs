namespace leetcode_sharp;

// 1872. Stone Game VIII
// https://leetcode.com/problems/stone-game-viii 
public class S01872
{
    public int StoneGameVIII(int[] stones)
    {
        var n = stones.Length;

        for (var i = 1; i < n; ++i)
        {
            stones[i] += stones[i - 1];
        }

        var dp = stones[^1];
        for (var i = n - 2; i > 0; --i)
        {
            dp = Math.Max(dp, stones[i] - dp);
        }

        return dp;
    }
}