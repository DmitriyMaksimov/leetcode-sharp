namespace leetcode_sharp;

// 242. Valid Anagram
// https://leetcode.com/problems/valid-anagram/
public class S00242
{
    public bool IsAnagram(string s, string t)
    {
        var sHash = calcHash(s);
        var tHash = calcHash(t);
        
        return hashEqual(sHash, tHash);
    }
    
    private static Dictionary<char, int> calcHash(string ransomNote)
    {
        var hash = new Dictionary<char, int>();
        foreach (var ch in ransomNote)
        {
            hash[ch] = hash.GetValueOrDefault(ch) + 1;
        }

        return hash;
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