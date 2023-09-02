namespace leetcode_sharp;

// 680. Valid Palindrome II
// https://leetcode.com/problems/valid-palindrome-ii/
public class S00680
{
    public bool ValidPalindrome(string s)
    {
        var i = 0;
        var j = s.Length - 1;

        while (i < j)
        {
            if (s[i] != s[j])
            {
                return isPalindrome(s, i + 1, j) || isPalindrome(s, i, j - 1);
            }

            i++;
            j--;
        }

        return true;
    }

    private static bool isPalindrome(string s, int i, int j)
    {
        while (i < j)
        {
            if (s[i] != s[j])
            {
                return false;
            }

            i++;
            j--;
        }

        return true;
    }
}