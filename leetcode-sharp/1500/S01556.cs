using System.Text;

namespace leetcode_sharp;

// 1556. Thousand Separator
// https://leetcode.com/problems/thousand-separator/
public class S01556
{
    public string ThousandSeparator(int n)
    {
        var s = n.ToString();
        var sb = new StringBuilder();
        var count = 0;

        for (var i = s.Length - 1; i >= 0; i--)
        {
            sb.Append(s[i]);
            if (++count != 3 || i == 0) continue;
            
            sb.Append('.');
            count = 0;
        }

        return new string(sb.ToString().ToCharArray().AsEnumerable().Reverse().ToArray());
    }
}