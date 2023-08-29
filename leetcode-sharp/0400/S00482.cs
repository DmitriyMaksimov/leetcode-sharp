using System.Text;

namespace leetcode_sharp;

// 482. License Key Formatting
// https://leetcode.com/problems/license-key-formatting/
public class S00482
{
    public string LicenseKeyFormatting(string s, int k)
    {
        var sb = new StringBuilder();
        var count = 0;
        for (var i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] == '-')
            {
                continue;
            }

            if (count == k)
            {
                sb.Append('-');
                count = 0;
            }

            sb.Append(char.ToUpper(s[i]));
            count++;
        }

        return new string(sb.ToString().Reverse().ToArray());
    }
}