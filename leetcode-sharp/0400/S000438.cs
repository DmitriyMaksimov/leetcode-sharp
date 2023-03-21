namespace leetcode_sharp;

// 438. Find All Anagrams in a String
// https://leetcode.com/problems/find-all-anagrams-in-a-string/
public class S000438
{
    public IList<int> FindAnagrams(string s, string p)
    {
        if (p.Length > s.Length)
        {
            return new List<int>();
        }
        
        var pHash = new Dictionary<char, int>();
        foreach (var ch in p)
        {
            pHash[ch] = pHash.GetValueOrDefault(ch) + 1;
        }

        var sHash = new Dictionary<char, int>();
        var windowSize = p.Length;
        
        foreach (var ch in s[..windowSize])
        {
            sHash[ch] = sHash.GetValueOrDefault(ch) + 1;
        }

        var result = new List<int>();

        if (hashEqual(pHash, sHash))
        {
            result.Add(0);
        }

        for (var i = 1; i <= s.Length - windowSize; i++)
        {
            // Remove char which is out of sliding window and add a new one
            var oldChar = s[i - 1];
            sHash[oldChar] -= 1;
            if (sHash[oldChar] == 0)
            {
                sHash.Remove(oldChar);
            }

            var newChar = s[i + windowSize - 1];
            sHash[newChar] = sHash.GetValueOrDefault(newChar) + 1;

            if (hashEqual(pHash, sHash))
            {
                result.Add(i);
            }
        }

        return result;
    }

    private static bool hashEqual(IReadOnlyDictionary<char, int> h1, IReadOnlyDictionary<char, int> h2)
    {
        if (h1.Count != h2.Count)
        {
            return false;
        }

        foreach (var (key, value) in h1)
        {
            if (!h2.TryGetValue(key, out var value2)) return false;
            if (value != value2)
            {
                return false;
            }
        }

        return true;
    }
}