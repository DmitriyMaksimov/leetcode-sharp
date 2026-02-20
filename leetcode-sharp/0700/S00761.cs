namespace leetcode_sharp;

// 761. Special Binary String
// https://leetcode.com/problems/special-binary-string
public class S00761
{
    public string MakeLargestSpecial(string s)
    {
        var count = 0;
        var start = 0;
        var parts = new List<string>();

        for (var i = 0; i < s.Length; i++)
        {
            count += s[i] == '1' ? 1 : -1;

            if (count == 0)
            {
                var inner = MakeLargestSpecial(s[(start + 1)..i]);
                parts.Add($"1{inner}0");
                start = i + 1;
            }
        }

        parts.Sort((a, b) => string.CompareOrdinal(b, a));

        return string.Concat(parts);
    }
}