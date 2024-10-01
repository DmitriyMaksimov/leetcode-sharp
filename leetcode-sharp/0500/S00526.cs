namespace leetcode_sharp;

// 526. Beautiful Arrangement
// https://leetcode.com/problems/beautiful-arrangement
public class S00526
{
    public int CountArrangement(int n)
    {
        var limit = 1 << n;
        var dp = Enumerable.Repeat(0, limit).ToArray();
        dp[0] = 1;

        for (var i = 0; i < limit; i++)
        {
            var pos = int.PopCount(i);

            for (var j = 0; j < n; j++)
            {
                if ((i & (1 << j)) == 0)
                {
                    var newMask = i | (1 << j);
                    if ((pos + 1) % (j + 1) == 0 || (j + 1) % (pos + 1) == 0)
                    {
                        dp[newMask] += dp[i];
                    }
                }
            }
        }

        return dp[(1 << n) - 1];
    }
}
