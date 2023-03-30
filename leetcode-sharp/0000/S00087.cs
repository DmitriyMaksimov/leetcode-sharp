namespace leetcode_sharp;

// 87. Scramble String
// https://leetcode.com/problems/scramble-string/
public class S00087
{
    private readonly Dictionary<string, bool> _memo = new();
    
    public bool IsScramble(string s1, string s2)
    {
        if (s1.Length != s2.Length)
        {
            return false;
        }

        return s1 == s2 || isScramble(s1, s2);
    }

    private bool isScramble(string s1, string s2)
    {
        if (s1.Length != s2.Length)
        {
            return false;
        }

        if (s1 == s2)
        {
            return true;
        }

        var key = s1 + "-" + s2;
        
        if (_memo.TryGetValue(key, out var cached))
        {
            return cached;
        }

        var n = s1.Length;

        for (var i = 1; i < n; i++)
        {
            if (isScramble(s1[..i], s2[..i]) && isScramble(s1[i..], s2[i..]))
            {
                return _memo[key] = true;
            }

            if (isScramble(s1[..i], s2[(n - i)..]) && isScramble(s1[i..], s2[..(n - i)]))
            {
                return _memo[key] = true;
            }
        }

        return _memo[key] = false;
    }
}