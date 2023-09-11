using System.Text;

namespace leetcode_sharp;

// 1694. Reformat Phone Number
// https://leetcode.com/problems/reformat-phone-number/
public class S01694
{
    public string ReformatNumber(string number)
    {
        var s = number.Replace(" ", "").Replace("-", "");
        var sb = new StringBuilder();

        for (var i = 0; i < s.Length;)
        {
            if (sb.Length > 0)
            {
                sb.Append('-');
            }

            if (s.Length - i == 4)
            {
                sb.Append(s.AsSpan(i, 2));
                sb.Append('-');
                sb.Append(s.AsSpan(i + 2, 2));
                break;
            }

            if (s.Length - i == 2)
            {
                sb.Append(s.AsSpan(i, 2));
                break;
            }

            sb.Append(s.AsSpan(i, 3));
            i += 3;
        }

        return sb.ToString();
    }
}