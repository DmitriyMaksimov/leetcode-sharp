namespace leetcode_sharp;

// 409. Longest Palindrome
// https://leetcode.com/problems/longest-palindrome/
public class S00409
{
    public int LongestPalindrome(string s)
    {
        var dict = new Dictionary<char, int>();

        foreach (var c in s)
        {
            dict[c] = dict.GetValueOrDefault(c) + 1;
        }

        var result = 0;
        var hasOdd = false;
        foreach (var (_, value) in dict)
        {
            if (value % 2 == 0)
            {
                result += value;
            }
            else
            {
                result += value - 1;
                hasOdd = true;
            }
        }

        return hasOdd ? result + 1 : result;
    }
}