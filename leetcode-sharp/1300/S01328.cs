namespace leetcode_sharp;

// 1328. Break a Palindrome
// https://leetcode.com/problems/break-a-palindrome
public class S01328
{
    public string BreakPalindrome(string palindrome)
    {
        var n = palindrome.Length;

        if (n == 1)
        {
            return "";
        }

        var chars = palindrome.ToCharArray();

        for (var i = 0; i < n / 2; i++)
        {
            if (chars[i] != 'a')
            {
                chars[i] = 'a';
                return new string(chars);
            }
        }

        chars[n - 1] = 'b';

        return new string(chars);
    }
}
