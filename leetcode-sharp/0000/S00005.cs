namespace leetcode_sharp;

// 5. Longest Palindromic Substring
// https://leetcode.com/problems/longest-palindromic-substring/
public class S00005
{
    public string? LongestPalindrome(string? s)
    {
        if (string.IsNullOrEmpty(s))
        {
            return s;
        }

        var isPalindrome = new HashSet<(int, int)>();

        string? res = null;

        for (var i = 0; i < s.Length; i++)
        {
            for (var j = i; j >= 0; j--)
            {
                if (s[i] == s[j] && (i - j < 2 || isPalindrome.Contains((j + 1, i - 1))))
                {
                    isPalindrome.Add((j, i));

                    var length = i - j + 1;

                    if ((res?.Length ?? 0) < length)
                    {
                        res = s.Substring(j, length);
                    }
                }
            }
        }

        return res;
    }
}