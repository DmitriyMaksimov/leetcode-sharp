using System.Text;

namespace leetcode_sharp;

// 3039. Apply Operations to Make String Empty
// https://leetcode.com/problems/apply-operations-to-make-string-empty
public class S03039
{
    public string LastNonEmptyString(string s)
    {
        var cnt = new int[26];
        var mx = s.Select(ch => ++cnt[ch - 'a']).Max();

        var last = new StringBuilder();
        for (var i = s.Length - 1; i >= 0; --i)
        {
            var c = s[i];
            if (mx == cnt[c - 'a']--)
            {
                last.Append(c);
            }
        }

        return new string(last.ToString().Reverse().ToArray());
    }
}
