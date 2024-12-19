namespace leetcode_sharp;

// 720. Longest Word in Dictionary
// https://leetcode.com/problems/longest-word-in-dictionary
public class S00720
{
    public string LongestWord(string[] words)
    {
        Array.Sort(words, (a, b) => a.Length == b.Length ? string.Compare(a, b, StringComparison.Ordinal) : a.Length - b.Length);

        var builtWords = new HashSet<string>();
        var result = "";

        foreach (var word in words)
        {
            if (word.Length != 1 && !builtWords.Contains(word[..^1]))
            {
                continue;
            }

            builtWords.Add(word);

            if (word.Length > result.Length || (word.Length == result.Length && string.Compare(word, result, StringComparison.Ordinal) < 0))
            {
                result = word;
            }
        }

        return result;
    }
}
