namespace leetcode_sharp;

// 756. Pyramid Transition Matrix
// https://leetcode.com/problems/pyramid-transition-matrix
public class S00756
{
    private const char Delimiter = '_';
    private readonly HashSet<string> _memo = [];

    public bool PyramidTransition(string bottom, IList<string> allowed)
    {
        var dictionary = new Dictionary<string, List<char>>();

        foreach (var s in allowed)
        {
            var key = s[..2];
            dictionary.TryAdd(key, []);
            dictionary[key].Add(s[2]);
        }

        return Dfs(dictionary, bottom + Delimiter);
    }

    private bool Dfs(Dictionary<string, List<char>> dictionary, string s)
    {
        if (s.Length == 1)
        {
            return true;
        }

        if (_memo.Contains(s))
        {
            return false;
        }

        var key = s[..2];

        if (key[1] == Delimiter)
        {
            return Dfs(dictionary, string.Concat(s.AsSpan(2), "_"));
        }

        if (dictionary.TryGetValue(key, out var nextChars))
        {
            foreach (var c in nextChars)
            {
                if (Dfs(dictionary, s[1..] + c))
                {
                    return true;
                }
            }
        }

        _memo.Add(s);

        return false;
    }
}
