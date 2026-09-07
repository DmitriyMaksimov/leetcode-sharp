namespace leetcode_sharp;

// 940. Distinct Subsequences II
// https://leetcode.com/problems/distinct-subsequences-ii
public class S00940
{
    public int DistinctSubseqII(string s)
    {
        const long Mod = 1_000_000_007;
        var end = new long[26];

        foreach (var c in s)
        {
            end[c - 'a'] = end.Sum() % Mod + 1;
        }

        return (int)(end.Sum() % Mod);
    }
}