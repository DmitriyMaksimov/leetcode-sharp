namespace leetcode_sharp;

// 890. Find and Replace Pattern
// https://leetcode.com/problems/find-and-replace-pattern
public class S00890
{
    public IList<string> FindAndReplacePattern(string[] words, string pattern)
    {
        var p = buildPattern(pattern);

        return words.Where(word => buildPattern(word).SequenceEqual(p)).ToList();
    }

    private static IEnumerable<int> buildPattern(string w)
    {
        var m = new Dictionary<char, int>();
        var n = w.Length;
        var res = new int[n];

        for (var i = 0; i < n; i++)
        {
            m.TryAdd(w[i], m.Count);
            res[i] = m[w[i]];
        }

        return res;
    }
}