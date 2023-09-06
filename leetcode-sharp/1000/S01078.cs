namespace leetcode_sharp;

// 1078. Occurrences After Bigram
// https://leetcode.com/problems/occurrences-after-bigram/
public class S01078
{
    public string[] FindOcurrences(string text, string first, string second)
    {
        var words = text.Split(' ');
        var result = new List<string>();

        for (var i = 0; i < words.Length - 2; i++)
        {
            if (words[i] == first && words[i + 1] == second)
            {
                result.Add(words[i + 2]);
            }
        }

        return result.ToArray();
    }
}