using System.Text;

namespace leetcode_sharp;

// 1417. Reformat The String
// https://leetcode.com/problems/reformat-the-string/
public class S01417
{
    public string Reformat(string s)
    {
        var digits = new List<char>();
        var letters = new List<char>();

        foreach (var c in s)
        {
            if (char.IsDigit(c))
            {
                digits.Add(c);
            }
            else
            {
                letters.Add(c);
            }
        }

        if (Math.Abs(digits.Count - letters.Count) > 1)
        {
            return string.Empty;
        }

        var result = new StringBuilder();
        var i = 0;
        var j = 0;
        var isDigit = digits.Count >= letters.Count;

        while (i < digits.Count || j < letters.Count)
        {
            result.Append(isDigit ? digits[i++] : letters[j++]);
            isDigit = !isDigit;
        }

        return result.ToString();
    }
}