namespace leetcode_sharp;

// 1531. String Compression II
// https://leetcode.com/problems/string-compression-ii
public class S01531
{
    private const int N = 127;
    private readonly int[,] _dp = new int[N, N];

    private int solve(string str, int left, int k)
    {
        if (k < 0)
        {
            return N;
        }

        var n = str.Length;

        if (left >= n || n - left <= k)
        {
            return 0;
        }

        var res = _dp[left, k];
        if (res != -1)
        {
            return res;
        }

        res = N;

        var cnt = new int[26];

        for (int j = left, most = 0; j < n; j++)
        {
            most = Math.Max(most, ++cnt[str[j] - 'a']);
            res = Math.Min(res, 1 + (most == 1 ? 0 : most < 10 ? 1 : most < 100 ? 2 : 3) + solve(str, j + 1, k - (j - left + 1 - most)));
        }

        return _dp[left, k] = res;
    }

    public int GetLengthOfOptimalCompression(string s, int k)
    {
        for (var i = 0; i < N; i++)
        {
            for (var j = 0; j < N; j++)
            {
                _dp[i, j] = -1;
            }
        }

        return solve(s, 0, k);
    }
}