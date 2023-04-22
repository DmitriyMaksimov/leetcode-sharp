namespace leetcode_sharp;

// 1312. Minimum Insertion Steps to Make a String Palindrome
// https://leetcode.com/problems/minimum-insertion-steps-to-make-a-string-palindrome/
public class S01312
{
    private readonly Dictionary<(int i, int j), int> _cache = new();

    public int MinInsertions(string s)
    {
        var reversedString = string.Join("", s.Reverse());
        return s.Length - getLCS(s, 0, reversedString, 0);
    }
    
    private int getLCS(string a, int i, string b, int j)
    {
        if (i >= a.Length || j >= b.Length)
        {
            return 0;
        }

        if (_cache.TryGetValue((i, j), out var value))
        {
            return value;
        }

        if (a[i] == b[j])
        {
            return _cache[(i, j)] = 1 + getLCS(a, i + 1, b, j + 1);
        }

        return _cache[(i, j)] = Math.Max(getLCS(a, i + 1, b, j), getLCS(a, i, b, j + 1));
    }
}