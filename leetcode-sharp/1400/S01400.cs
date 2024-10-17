namespace leetcode_sharp;

// 1400. Construct K Palindrome Strings
// https://leetcode.com/problems/construct-k-palindrome-strings
public class S01400
{
    public bool CanConstruct(string s, int k)
    {
        var odd = 0;
        var n = s.Length;
        var counts = new int[26];

        for (var i = 0; i < n; ++i)
        {
            counts[s[i] - 'a'] ^= 1;
            odd += counts[s[i] - 'a'] > 0 ? 1 : -1;
        }

        return odd <= k && k <= n;
    }
}
