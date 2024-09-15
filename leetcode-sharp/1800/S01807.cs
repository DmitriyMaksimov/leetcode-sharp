using System.Text;

namespace leetcode_sharp;

// 1807. Evaluate the Bracket Pairs of a String
// https://leetcode.com/problems/evaluate-the-bracket-pairs-of-a-string
public class S01807
{
    public string Evaluate(string s, IList<IList<string>> knowledge)
    {
        var map = knowledge.ToDictionary(pair => pair[0], pair => pair[1]);
        var sb = new StringBuilder();

        for (var i = 0; i < s.Length; i++)
        {
            var c = s[i];
            if (c == '(')
            {
                var j = s.IndexOf(')', i);
                sb.Append(map.GetValueOrDefault(s.Substring(i + 1, j - i - 1), "?"));
                i = j;
            }
            else
            {
                sb.Append(c);
            }
        }

        return sb.ToString();
    }
}
