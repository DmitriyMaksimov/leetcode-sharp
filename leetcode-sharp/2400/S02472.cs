namespace leetcode_sharp;

// 2472. Maximum Number of Non-overlapping Palindrome Substrings
// https://leetcode.com/problems/maximum-number-of-non-overlapping-palindrome-substrings
public class S02472
{
    public int MaxPalindromes(string s, int k)
    {
        var n = s.Length;
        var result = 0;
        var start = 0;

        for (var center = 0; center < 2 * n; center++)
        {
            var left = center / 2;
            var right = left + center % 2;
            while (left >= start && right < n && s[left] == s[right])
            {
                if (right + 1 - left >= k)
                {
                    result++;
                    start = right + 1;
                    break;
                }

                left--;
                right++;
            }
        }

        return result;
    }
}