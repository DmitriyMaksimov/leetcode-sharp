using System.Text;

namespace leetcode_sharp;

// 3612. Process String with Special Operations I
// https://leetcode.com/problems/process-string-with-special-operations-i
public class S03612
{
    public string ProcessStr(string s)
    {
        var result = new StringBuilder();

        foreach (var c in s)
        {
            if (c != '*' && c != '#' && c != '%')
            {
                result.Append(c);
            }
            else if (c == '#')
            {
                result.Append(result);
            }
            else if (c == '%')
            {
                var reversed = new string(result.ToString().Reverse().ToArray());
                result.Clear().Append(reversed);
            }
            else
            {
                if (result.Length > 0)
                {
                    result.Length--;
                }
            }
        }

        return result.ToString();
    }
}