namespace leetcode_sharp;

// 647. Palindromic Substrings
// https://leetcode.com/problems/palindromic-substrings
public class S00647
{
    public int CountSubstrings(string s)
    {
        var cnt = 0;
        var n = s.Length;
        for (var i = 0; i < n; i++)
        {
            cnt += countPalindromic(s, i, i);
            cnt += countPalindromic(s, i, i + 1);
        }

        return cnt;
    }

    private static int countPalindromic(string s, int i, int j)
    {
        var cnt = 0;

        while (i >= 0 && j < s.Length && s[i] == s[j])
        {
            cnt++;
            i--;
            j++;
        }

        return cnt;
    }
}