using System.Text.RegularExpressions;

namespace leetcode_sharp;

// 831. Masking Personal Information
// https://leetcode.com/problems/masking-personal-information
public class S00831
{
    public string MaskPII(string s)
    {
        if (s.Contains('@'))
        {
            var parts = s.ToLower().Split('@');
            var name = parts[0];
            var domain = parts[1];

            return $"{name[0]}*****{name[^1]}@{domain}";
        }

        var s2 = Regex.Replace(s, """[\(\)\-\+ ]""", "");
        var count = s2.Length > 10 ? $"+{new string('*', s2.Length - 10)}-" : "";

        return $"{count}***-***-{s2[^4..]}";
    }
}
