namespace leetcode_sharp;

// 125. Valid Palindrome
// https://leetcode.com/problems/valid-palindrome/
public class S00125
{
    public bool IsPalindrome(string s)
    {
        return isPalindrome(new string(s.Where(c => char.IsLetter(c) || char.IsNumber(c)).Select(char.ToLower).ToArray()));
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