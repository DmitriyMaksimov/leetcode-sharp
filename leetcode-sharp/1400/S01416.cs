namespace leetcode_sharp;

// 1416. Restore The Array
// https://leetcode.com/problems/restore-the-array/
public class S01416
{
    private const int Mod = 1000000007;
    private int[] _dp;
    private int _k;

    public int NumberOfArrays(string s, int k)
    {
        _dp = new int[s.Length + 1];
        _k = k;
        return dfs(s, 0);
    }

    private int dfs(string s, int i)
    {
        if (i == s.Length)
        {
            // Final element => only 1 variant
            return 1;
        }

        if (s[i] == '0')
        {
            // There are no leading zeros in the array => return 0
            return 0;
        }

        if (_dp[i] != 0)
        {
            return _dp[i];
        }

        var num = 0L;
        
        for (var j = 1; i + j <= s.Length; ++j)
        {
            num = num * 10 + s[i + j - 1] - '0';

            if (num > _k)
            {
                // Exceed max K
                break;
            }

            _dp[i] = (_dp[i] + dfs(s, i + j)) % Mod;
        }

        return _dp[i];
    }
}