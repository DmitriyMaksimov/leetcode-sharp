using System.Text;

namespace leetcode_sharp;

// 1961. Check If String Is a Prefix of Array
// https://leetcode.com/problems/check-if-string-is-a-prefix-of-array/
public class S01961
{
    public bool IsPrefixString(string s, string[] words)
    {
        var sb = new StringBuilder();

        foreach (var word in words)
        {
            sb.Append(word);

            if (sb.ToString() == s)
            {
                return true;
            }
        }

        return false;
    }
}