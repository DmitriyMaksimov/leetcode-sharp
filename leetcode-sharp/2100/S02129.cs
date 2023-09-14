using System.Text;

namespace leetcode_sharp;

// 2129. Capitalize the Title
// https://leetcode.com/problems/capitalize-the-title/
public class S02129
{
    public string CapitalizeTitle(string title)
    {
        var sb = new StringBuilder();

        foreach (var word in title.Split(' '))
        {
            if (word.Length < 3)
            {
                sb.Append(word.ToLower());
            }
            else
            {
                sb.Append(char.ToUpper(word[0]));
                sb.Append(word[1..].ToLower());
            }

            sb.Append(' ');
        }

        return sb.ToString().TrimEnd();
    }
}