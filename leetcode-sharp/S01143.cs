namespace leetcode_sharp;

// 1143. Longest Common Subsequence
// https://leetcode.com/problems/longest-common-subsequence/description/
public class S01143
{
    private readonly Dictionary<(int i, int j), int> _cache = new();
    
    public int LongestCommonSubsequence(string text1, string text2)
    {
        return getLCS(text1, 0, text2, 0);
    }

    private int getLCS(string a, int i, string b, int j)
    {
        if (i >= a.Length || j >= b.Length)
        {
            return 0;
        }

        if (_cache.TryGetValue((i, j), out var value))
        {
            return value;
        }

        if (a[i] == b[j])
        {
            return _cache[(i, j)] = 1 + getLCS(a, i + 1, b, j + 1);
        }

        return _cache[(i, j)] = Math.Max(getLCS(a, i + 1, b, j), getLCS(a, i, b, j + 1));
    }
}