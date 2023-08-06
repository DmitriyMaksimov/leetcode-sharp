namespace leetcode_sharp;

// 920. Number of Music Playlists
// https://leetcode.com/problems/number-of-music-playlists/
public class S00920
{
    public int NumMusicPlaylists(int n, int goal, int k)
    {
        const int mod = 1_000_000_007;
        var dp = new long[2, n + 1];

        dp[0, 0] = 1;

        for (var i = 1; i <= goal; i++)
        {
            dp[i % 2, 0] = 0;
            for (var j = 1; j <= Math.Min(i, n); j++)
            {
                dp[i % 2, j] = dp[(i - 1) % 2, j - 1] * (n - (j - 1)) % mod;
                if (j > k)
                {
                    dp[i % 2, j] = (dp[i % 2, j] + dp[(i - 1) % 2, j] * (j - k)) % mod;
                }
            }
        }

        return (int) dp[goal % 2, n];
    }
}