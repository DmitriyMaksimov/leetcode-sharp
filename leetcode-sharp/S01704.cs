namespace leetcode_sharp;

// 1704. Determine if String Halves Are Alike
// https://leetcode.com/problems/determine-if-string-halves-are-alike/
public class S01704
{
    public bool HalvesAreAlike(string s)
    {
        var vowels = new HashSet<char> {'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'};

        var halfLength = s.Length / 2;

        return s[..halfLength].Count(c => vowels.Contains(c)) == s[halfLength..].Count(c => vowels.Contains(c));
    }
}