namespace leetcode_sharp;

// 115. Distinct Subsequences
// https://leetcode.com/problems/distinct-subsequences
public class S00115
{
    public int NumDistinct(string s, string t)
    {
        var mem = new int[t.Length + 1, s.Length + 1];
        for (var j = 0; j <= s.Length; j++)
        {
            mem[0, j] = 1;
        }

        for (var i = 0; i < t.Length; i++)
        {
            for (var j = 0; j < s.Length; j++)
            {
                mem[i + 1, j + 1] = t[i] == s[j] ? mem[i, j] + mem[i + 1, j] : mem[i + 1, j];
            }
        }

        return mem[t.Length, s.Length];
    }
}