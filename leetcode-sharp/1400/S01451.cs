using System.Text;

namespace leetcode_sharp;

// 1451. Rearrange Words in a Sentence
// https://leetcode.com/problems/rearrange-words-in-a-sentence
public class S01451
{
    public string ArrangeWords(string text)
    {
        Dictionary<int, string> dictionary = [];

        foreach (var word in text.ToLower().Split(" "))
        {
            dictionary[word.Length] = dictionary.GetValueOrDefault(word.Length, "") + word + " ";
        }

        var sb = new StringBuilder();

        foreach (var key in dictionary.Keys.Order())
        {
            sb.Append(dictionary[key]);
        }

        var result = sb.ToString().TrimEnd();

        return char.ToUpper(result[0]) + result[1..];
    }
}
