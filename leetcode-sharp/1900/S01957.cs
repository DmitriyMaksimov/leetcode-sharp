using System.Text;

namespace leetcode_sharp;

// 1957. Delete Characters to Make Fancy String
// https://leetcode.com/problems/delete-characters-to-make-fancy-string/
public class S01957
{
    public string MakeFancyString(string s)
    {
        var sb = new StringBuilder();
        var count = 0;
        var prev = ' ';
        foreach (var c in s)
        {
            if (c == prev)
            {
                count++;
            }
            else
            {
                count = 1;
                prev = c;
            }

            if (count < 3)
            {
                sb.Append(c);
            }
        }

        return sb.ToString();
    }
}