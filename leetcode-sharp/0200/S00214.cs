namespace leetcode_sharp;

// 214. Shortest Palindrome
// https://leetcode.com/problems/shortest-palindrome
public class S00214
{
    public string ShortestPalindrome(string s)
    {
        var cnt = Kmp(new string(s.Reverse().ToArray()), s);
        return new string(s[cnt..].Reverse().ToArray()) + s;
    }

    private static int Kmp(string text, string pattern)
    {
        var newString = pattern + '#' + text;
        var ind = new int[newString.Length];
        var i = 1;
        var k = 0;

        while (i < newString.Length)
        {
            if (newString[i] == newString[k])
            {
                ind[i++] = ++k;
            }
            else
            {
                if (k > 0)
                {
                    k = ind[k - 1];
                }
                else
                {
                    ind[i++] = 0;
                }
            }
        }

        return ind[newString.Length - 1];
    }
}
