using System.Text;

namespace leetcode_sharp;

// 833. Find And Replace in String
// https://leetcode.com/problems/find-and-replace-in-string
public class S00833
{
    public string FindReplaceString(string s, int[] indices, string[] sources, string[] targets)
    {
        var dictionary = new Dictionary<int, int>();

        for (var i = 0; i < indices.Length; i++)
        {
            if (s[indices[i]..].StartsWith(sources[i]))
            {
                dictionary[indices[i]] = i;
            }
        }

        var sb = new StringBuilder();

        for (var i = 0; i < s.Length;)
        {
            if (dictionary.TryGetValue(i, out var index))
            {
                sb.Append(targets[index]);
                i += sources[index].Length;
            }
            else
            {
                sb.Append(s[i]);
                i++;
            }
        }

        return sb.ToString();
    }
}
