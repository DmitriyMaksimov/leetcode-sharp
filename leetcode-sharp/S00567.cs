namespace leetcode_sharp;

// 567. Permutation in String
// https://leetcode.com/problems/permutation-in-string/
public class S00567
{
    public bool CheckInclusion(string s1, string s2)
    {
        if (s1.Length > s2.Length)
        {
            return false;
        }
        
        var d1 = new Dictionary<char, int>();
        var d2 = new Dictionary<char, int>();
        
        foreach (var ch in s1)
        {
            d1[ch] = d1.GetValueOrDefault(ch) + 1;
        }

        foreach (var ch in s2[..s1.Length])
        {
            d2[ch] = d2.GetValueOrDefault(ch) + 1;
        }

        if (dictionariesEqual(d1, d2))
        {
            return true;
        }

        for (var i = s1.Length; i < s2.Length; i++)
        {
            var firstCh = s2[i - s1.Length];
            var ch = s2[i];

            d2[firstCh] -= 1;
            d2[ch] = d2.GetValueOrDefault(ch) + 1;

            if (dictionariesEqual(d1, d2))
            {
                return true;
            }
        }

        return false;
    }

    private static bool dictionariesEqual(IReadOnlyDictionary<char, int> d1, IReadOnlyDictionary<char, int> d2)
    {
        var found = true;

        foreach (var (key, value) in d1)
        {
            if (!d2.ContainsKey(key) || d2[key] != value)
            {
                found = false;
                break;
            }
        }

        return found;
    }
}