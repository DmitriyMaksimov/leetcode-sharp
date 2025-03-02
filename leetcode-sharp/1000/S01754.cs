using System.Text;

namespace leetcode_sharp;

// 1754. Largest Merge Of Two Strings
// https://leetcode.com/problems/largest-merge-of-two-strings
public class S01754
{
    public string LargestMerge(string word1, string word2)
    {
        var res = new StringBuilder();
        var i = 0;
        var j = 0;

        while (i < word1.Length && j < word2.Length)
        {
            res.Append(string.Compare(word1, i, word2, j, Math.Max(word1.Length - i, word2.Length - j), StringComparison.Ordinal) > 0 ? word1[i++] : word2[j++]);
        }

        return res.Append(word1[i..]).Append(word2[j..]).ToString();
    }
}
