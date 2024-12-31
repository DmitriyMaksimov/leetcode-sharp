namespace leetcode_sharp;

// 524. Longest Word in Dictionary through Deleting
// https://leetcode.com/problems/longest-word-in-dictionary-through-deleting
public class S00524
{
    public string FindLongestWord(string s, IList<string> dictionary)
    {
        var result = "";

        foreach (var word in dictionary)
        {
            if (!CanFormByDeleting(word, s))
            {
                continue;
            }

            if (word.Length > result.Length || (word.Length == result.Length && string.Compare(word, result, StringComparison.InvariantCulture) < 0))
            {
                result = word;
            }
        }

        return result;
    }

    private static bool CanFormByDeleting(string word, string str)
    {
        var wordIndex = 0;
        var strIndex = 0;

        while (wordIndex < word.Length && strIndex < str.Length)
        {
            if (word[wordIndex] == str[strIndex])
            {
                wordIndex++;
            }

            strIndex++;
        }

        return wordIndex == word.Length;
    }
}
