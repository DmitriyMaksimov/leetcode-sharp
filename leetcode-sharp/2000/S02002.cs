namespace leetcode_sharp;

// 2002. Maximum Product of the Length of Two Palindromic Subsequences
// https://leetcode.com/problems/maximum-product-of-the-length-of-two-palindromic-subsequences
public class S02002
{
    private int _max;

    public int MaxProduct(string s)
    {
        var charArray = s.ToCharArray();
        Dfs(charArray, 0, "", "");
        return _max;
    }

    private void Dfs(char[] c, int i, string s1, string s2)
    {
        if (i >= c.Length)
        {
            if (IsPalindrome(s1) && IsPalindrome(s2))
            {
                _max = Math.Max(_max, s1.Length * s2.Length);
            }

            return;
        }

        Dfs(c, i + 1, s1 + c[i], s2);
        Dfs(c, i + 1, s1, s2 + c[i]);
        Dfs(c, i + 1, s1, s2);
    }

    private static bool IsPalindrome(string str)
    {
        var i = 0;
        var j = str.Length - 1;

        while (i < j)
        {
            if (str[i] != str[j])
            {
                return false;
            }

            i++;
            j--;
        }

        return true;
    }
}
