using System.Text;

namespace leetcode_sharp;

// 1309. Decrypt String from Alphabet to Integer Mapping
// https://leetcode.com/problems/decrypt-string-from-alphabet-to-integer-mapping/
public class S01309
{
    public string FreqAlphabets(string s)
    {
        var result = new StringBuilder();
        
        for (var i = 0; i < s.Length; i++)
        {
            if (i + 2 < s.Length && s[i + 2] == '#')
            {
                var n = (s[i] - '0') * 10 + (s[i + 1] - '0');
                result.Append((char) ('j' + n - 10));
                i += 2;
            }
            else
            {
                result.Append((char) ('a' + s[i] - '1'));
            }
        }

        return result.ToString();
    }
}