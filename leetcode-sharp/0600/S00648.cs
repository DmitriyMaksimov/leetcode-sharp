using System.Text;

namespace leetcode_sharp;

// 648. Replace Words
// https://leetcode.com/problems/replace-words
public class S00648
{
    public string ReplaceWords(IList<string> dictionary, string sentence)
    {
        var set = dictionary.ToHashSet();
        var stringBuilder = new StringBuilder();
        var words = sentence.Split(" ", StringSplitOptions.RemoveEmptyEntries);

        foreach (var word in words)
        {
            var prefix = "";

            for (var i = 1; i <= word.Length; i++)
            {
                prefix = word[..i];
                if (set.Contains(prefix)) break;
            }

            stringBuilder.Append(" " + prefix);
        }

        return stringBuilder.ToString()[1..];
    }
}