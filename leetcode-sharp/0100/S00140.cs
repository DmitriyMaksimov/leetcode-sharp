namespace leetcode_sharp;

// 140. Word Break II
// https://leetcode.com/problems/word-break-ii
public class S00140
{
    private readonly Dictionary<string, List<string>> _memo = [];

    public IList<string> WordBreak(string s, IList<string> wordDict)
    {
        return Dfs(s, wordDict.ToHashSet());
    }

    private List<string> Dfs(string s, HashSet<string> wordDict)
    {
        if (_memo.TryGetValue(s, out var val))
        {
            return val;
        }

        List<string> res = [];

        if (s.Length == 0)
        {
            res.Add("");
            return res;
        }

        foreach (var word in wordDict)
        {
            if (s.StartsWith(word))
            {
                var sublist = Dfs(s.Substring(word.Length), wordDict);
                res.AddRange(sublist.Select(sub => word + (sub.Length != 0 ? " " : "") + sub));
            }
        }

        _memo[s] = res;
        return res;
    }
}