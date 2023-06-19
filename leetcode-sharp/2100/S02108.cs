namespace leetcode_sharp;

// 2108. Find First Palindromic String in the Array
// https://leetcode.com/problems/find-first-palindromic-string-in-the-array/
public class S02108
{
    public string FirstPalindrome(string[] words)
    {
        return words.FirstOrDefault(isPalindrome, "");
    }

    private static bool isPalindrome(string s)
    {
        for (var i = 0; i < s.Length / 2; i++)
        {
            if (s[i] != s[s.Length - i - 1]) return false;
        }

        return true;
    }
}