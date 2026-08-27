namespace leetcode_sharp;

// 3720. Lexicographically Smallest Permutation Greater Than Target
// https://leetcode.com/problems/lexicographically-smallest-permutation-greater-than-target
public class S03720
{
    private string _result = "";

    public string LexGreaterPermutation(string s, string target)
    {
        var cnt = new int[26];

        foreach (var c in s)
        {
            cnt[c - 'a']++;
        }

        _result = "";

        var path = new List<char>();

        Backtrack(path, cnt, target, false);
        
        return _result;
    }

    private bool Backtrack(List<char> path, int[] cnt, string target, bool greater)
    {
        var n = target.Length;

        if (!string.IsNullOrEmpty(_result))
        {
            return true;
        }

        if (path.Count == n)
        {
            if (!greater)
            {
                return false;
            }

            _result = new string(path.ToArray());
            return true;

        }

        var i = path.Count;

        for (var c = 0; c < 26; c++)
        {
            if (cnt[c] == 0)
            {
                continue;
            }

            var ch = (char)('a' + c);

            if (!greater && ch < target[i])
            {
                continue;
            }

            path.Add(ch);
            cnt[c]--;

            var newGreater = greater || ch > target[i];

            if (Backtrack(path, cnt, target, newGreater))
            {
                return true;
            }

            path.RemoveAt(path.Count - 1);
            cnt[c]++;
        }

        return false;
    }
}