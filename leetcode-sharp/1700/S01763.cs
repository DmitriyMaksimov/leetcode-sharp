namespace leetcode_sharp;

// 1763. Longest Nice Substring
// https://leetcode.com/problems/longest-nice-substring/
public class S01763
{
    public string LongestNiceSubstring(string s)
    {
        var n = s.Length;
        if (n == 1) return "";

        var hashSet = new HashSet<char>(s.ToCharArray());

        for (var i = 0; i < n; i++)
        {
            if (hashSet.Contains(char.ToLower(s[i])) && hashSet.Contains(char.ToUpper(s[i]))) continue;
            var prev = LongestNiceSubstring(s[..i]); 
            var next = LongestNiceSubstring(s[(i + 1)..]);

            return prev.Length >= next.Length ? prev : next;
        }

        return s;
    }
}