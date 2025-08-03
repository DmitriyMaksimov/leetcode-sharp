namespace leetcode_sharp;

// 403. Frog Jump
// https://leetcode.com/problems/frog-jump/
public class S00403
{
    public bool CanCross(int[] stones)
    {
        var dp = new HashSet<int>[stones.Length];

        for (var i = 0; i < dp.Length; i++)
        {
            dp[i] = [];
        }

        dp[0].Add(0);

        for (var i = 0; i < stones.Length; i++)
        {
            var lst = dp[i];

            foreach (var jump in lst)
            {
                for (var j = i + 1; j < stones.Length && stones[j] - stones[i] - jump <= 1; ++j)
                {
                    if (Math.Abs(stones[j] - stones[i] - jump) <= 1)
                    {
                        dp[j].Add(stones[j] - stones[i]);
                    }
                }
            }
        }

        return dp[stones.Length - 1].Count > 0;
    }
}