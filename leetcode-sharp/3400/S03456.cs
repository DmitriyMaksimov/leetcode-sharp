namespace leetcode_sharp;

// 3456. Find Special Substring of Length K
// https://leetcode.com/problems/find-special-substring-of-length-k
public class S03456
{
    public bool HasSpecialSubstring(string s, int k)
    {
        var currentChar = '\0';
        var count = 0;

        for (var i = 0; i < s.Length; i++)
        {
            if (s[i] == currentChar)
            {
                count++;
            }
            else
            {
                count = 1;
                currentChar = s[i];
            }

            if (count == k && (i == s.Length - 1 || s[i + 1] != currentChar))
            {
                return true;
            }
        }

        return false;
    }
}
