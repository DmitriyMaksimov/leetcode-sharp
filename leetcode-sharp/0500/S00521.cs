namespace leetcode_sharp;

// 521. Longest Uncommon Subsequence I
// https://leetcode.com/problems/longest-uncommon-subsequence-i/
public class S00521
{
    public int FindLUSlength(string a, string b)
    {
        if (a == b)
        {
            return -1;
        }

        return Math.Max(a.Length, b.Length);
    }
}