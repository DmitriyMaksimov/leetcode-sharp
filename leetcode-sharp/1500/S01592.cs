using System.Text;

namespace leetcode_sharp;

// 1592. Rearrange Spaces Between Words
// https://leetcode.com/problems/rearrange-spaces-between-words/
public class S01592
{
    public string ReorderSpaces(string text)
    {
        var spaces = 0;
        var words = new List<string>();
        var word = new StringBuilder();
        foreach (var c in text)
        {
            if (c == ' ')
            {
                spaces++;
                if (word.Length <= 0) continue;
                words.Add(word.ToString());
                word.Clear();
            }
            else
            {
                word.Append(c);
            }
        }

        if (word.Length > 0)
        {
            words.Add(word.ToString());
        }

        var result = new StringBuilder();
        if (words.Count == 1)
        {
            result.Append(words[0]);
            for (var i = 0; i < spaces; i++)
            {
                result.Append(' ');
            }
        }
        else
        {
            var space = spaces / (words.Count - 1);
            var remain = spaces % (words.Count - 1);
            for (var i = 0; i < words.Count; i++)
            {
                result.Append(words[i]);
                if (i >= words.Count - 1) continue;
                for (var j = 0; j < space; j++)
                {
                    result.Append(' ');
                }
            }

            for (var i = 0; i < remain; i++)
            {
                result.Append(' ');
            }
        }

        return result.ToString();
    }
}