namespace leetcode_sharp;

// 290. Word Pattern
// https://leetcode.com/problems/word-pattern/
public class S00290
{
    public bool WordPattern(string pattern, string s)
    {
        var matches = new Dictionary<char, string>();
        var strings = s.Split(' ').ToArray();
        var words = new HashSet<string>();

        if (strings.Length != pattern.Length)
        {
            return false;
        }
        
        for (var i = 0; i < pattern.Length; i++)
        {
            var ch = pattern[i];
            var word = strings[i];
            
            if (matches.ContainsKey(ch))
            {
                if (matches[ch] != word)
                {
                    return false;
                }
            }
            else
            {
                if (words.Contains(word))
                {
                    return false;
                }
                matches[ch] = word;
                words.Add(word);
            }
        }

        return true;
    }
}