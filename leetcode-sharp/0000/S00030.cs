namespace leetcode_sharp;

// 30. Substring with Concatenation of All Words
// https://leetcode.com/problems/substring-with-concatenation-of-all-words/
public class S00030
{
    private static bool ContentEquals<TKey, TValue>(Dictionary<TKey, TValue> dictionary, Dictionary<TKey, TValue> otherDictionary) where TKey : notnull
    {
        return otherDictionary
            .OrderBy(kvp => kvp.Key)
            .SequenceEqual(dictionary.OrderBy(kvp => kvp.Key));
    }

    public IList<int> FindSubstring(string s, string[] words)
    {
        var n = words.Length;
        var len = words[0].Length;
        var result = new List<int>();

        var mp = new Dictionary<string, int>();

        foreach (var str in words)
        {
            mp[str] = mp.GetValueOrDefault(str) + 1;
        }

        for (var i = 0; i < s.Length - (n * len) + 1; i++)
        {
            var m = new Dictionary<string, int>();
            for (var j = i; j < i + n * len; j += len)
            {
                var str = s.Substring(j, len);
                m[str] = m.GetValueOrDefault(str) + 1;
            }

            if (ContentEquals(mp, m))
            {
                result.Add(i);
            }
        }

        return result;
    }
}