using System.Text;

namespace leetcode_sharp;

// 1625. Lexicographically Smallest String After Applying Operations
// https://leetcode.com/problems/lexicographically-smallest-string-after-applying-operations
public class S01625
{
    string _smallest;
    private readonly HashSet<string> _set = [];

    public string FindLexSmallestString(string s, int a, int b)
    {
        _smallest = s;

        Helper(s, a, b);

        return _smallest;
    }

    private void Helper(string s, int a, int b)
    {
        if (_set.Contains(s))
        {
            return;
        }

        if (string.Compare(s, _smallest, StringComparison.Ordinal) < 0)
        {
            _smallest = s;
        }

        _set.Add(s);

        Helper(Rotate(s, b), a, b);
        Helper(Add(s, a), a, b);
    }

    private static string Rotate(string s, int pos)
    {
        var len = s.Length - pos;
        return s.Substring(len) + s.Substring(0, len);
    }

    private static string Add(string s, int a)
    {
        var sb = new StringBuilder();
        for (var i = 0; i < s.Length; i++)
        {
            var c = s[i];

            if (i % 2 == 1)
            {
                c = (char)((c - '0' + a) % 10 + '0');
            }

            sb.Append(c);
        }

        return sb.ToString();
    }
}
