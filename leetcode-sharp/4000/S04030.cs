using System.Text;

namespace leetcode_sharp;

// 4030. Check ASCII Palindromic
// https://leetcode.com/problems/check-ascii-palindromic
public class S04030
{
    public bool IsPalindromic(string s)
    {
        var stringBuilder = new StringBuilder(s.Length * 8);

        foreach (int c in s)
        {
            stringBuilder.Append($"{c:b8}");
        }

        return IsPalindrome(stringBuilder.ToString());
    }

    private static bool IsPalindrome(string s)
    {
        for (var i = 0; i < s.Length / 2; i++)
        {
            if (s[i] != s[s.Length - i - 1])
            {
                return false;
            }
        }

        return true;
    }
}