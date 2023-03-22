namespace leetcode_sharp;

// 139. Word Break
// https://leetcode.com/problems/word-break/
public class S00139
{
    private HashSet<string> _hashSet;
    private readonly Dictionary<int, bool> _memo = new();

    public bool WordBreak(string s, IList<string> wordDict)
    {
        _hashSet = wordDict.ToHashSet();

        return wordBreak(s, 0);
    }

    private bool wordBreak(string s, int startPosition)
    {
        if (startPosition >= s.Length)
        {
            return true;
        }

        if (_memo.TryGetValue(startPosition, out var result))
        {
            return result;
        }
        
        for (var i = startPosition + 1; i <= s.Length; i++)
        {
            if (_hashSet.Contains(s[startPosition..i]) && wordBreak(s, i))
            {
                return _memo[startPosition] = true;
            }
        }

        return _memo[startPosition] = false;
    }
}