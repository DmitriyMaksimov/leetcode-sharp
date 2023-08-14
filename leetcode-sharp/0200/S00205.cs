namespace leetcode_sharp;

// 205. Isomorphic Strings
// https://leetcode.com/problems/isomorphic-strings/
public class S00205
{
    public bool IsIsomorphic(string s, string t)
    {
        var dictionary = new Dictionary<char, char>();

        for (var i = 0; i < s.Length; i++)
        {
            var charS = s[i];
            var charT = t[i];
 
            if (dictionary.TryGetValue(charS, out var value))
            {
                if (charT != value)
                {
                    return false;
                }
            }
            else
            {
                if (dictionary.ContainsValue(charT))
                {
                    return false;
                }

                dictionary.Add(charS, charT);
            }
        }

        return true;
    }
}