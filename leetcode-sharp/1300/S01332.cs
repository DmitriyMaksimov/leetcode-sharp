namespace leetcode_sharp;

// 1332. Remove Palindromic Subsequences
// https://leetcode.com/problems/remove-palindromic-subsequences/
public class S01332
{
    public int RemovePalindromeSub(string s)
    {
        if (s.Length == 0)
        {
            return 0;
        }

        return isPalindrome(s) ? 1 : 2;
    }
    
    private static bool isPalindrome(string s)
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