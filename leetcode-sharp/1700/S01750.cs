namespace leetcode_sharp;

// 1750. Minimum Length of String After Deleting Similar Ends
// https://leetcode.com/problems/minimum-length-of-string-after-deleting-similar-ends
public class S01750
{
    public int MinimumLength(string s)
    {
        var left = 0;
        var right = s.Length - 1;

        while (left < right && s[left] == s[right])
        {
            var ch = s[left];

            while (left <= right && s[left] == ch)
            {
                ++left;
            }

            while (left < right && s[right] == ch)
            {
                --right;
            }
        }

        return right - left + 1;
    }
}