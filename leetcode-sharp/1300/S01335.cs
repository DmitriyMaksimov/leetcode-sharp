namespace leetcode_sharp;

// 1335. Minimum Difficulty of a Job Schedule
// https://leetcode.com/problems/minimum-difficulty-of-a-job-schedule
public class S01335
{
    public int MinDifficulty(int[] jobDifficulty, int d)
    {
        var n = jobDifficulty.Length;

        if (n < d)
        {
            return -1;
        }

        if (n == d)
        {
            var totalDifficulty = jobDifficulty.Sum();
            return totalDifficulty;
        }

        var dp = new int[n];
        dp[0] = jobDifficulty[0];

        for (var i = 1; i < n; i++)
        {
            dp[i] = Math.Max(dp[i - 1], jobDifficulty[i]);
        }

        var dpPrev = new int[n];

        for (var i = 1; i < d; i++)
        {
            (dpPrev, dp) = (dp, dpPrev);

            for (var j = i; j < n; j++)
            {
                var lastDayDifficulty = jobDifficulty[j];
                var tmpMin = lastDayDifficulty + dpPrev[j - 1];

                for (var t = j - 1; t >= i; t--)
                {
                    lastDayDifficulty = Math.Max(lastDayDifficulty, jobDifficulty[t]);
                    tmpMin = Math.Min(tmpMin, lastDayDifficulty + dpPrev[t - 1]);
                }

                dp[j] = tmpMin;
            }
        }

        return dp[n - 1];
    }
}