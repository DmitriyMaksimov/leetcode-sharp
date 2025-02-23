namespace leetcode_sharp;

// 1824. Minimum Sideway Jumps
// https://leetcode.com/problems/minimum-sideway-jumps
public class S01824
{
    public int MinSideJumps(int[] obstacles)
    {
        const int numberOfLanes = 3;
        var n = obstacles.Length - 1;
        var dp = new int[n, numberOfLanes];
        dp[0, 1] = 0;
        dp[0, 0] = dp[0, 2] = 1;

        for (var i = 1; i < n; ++i)
        {
            for (var r = 0; r < numberOfLanes; ++r)
            {
                if (obstacles[i] == r + 1 || obstacles[i + 1] == r + 1)
                {
                    dp[i, r] = n;
                }
                else
                {
                    dp[i, r] = Math.Min(dp[i - 1, r], Math.Min(dp[i - 1, (r + 1) % numberOfLanes], dp[i - 1, (r + 2) % numberOfLanes]) + 1);
                }
            }
        }

        return Math.Min(dp[n - 1, 0], Math.Min(dp[n - 1, 1], dp[n - 1, 2]));
    }
}
