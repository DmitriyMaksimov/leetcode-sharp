namespace leetcode_sharp;

// 1455. Check If a Word Occurs As a Prefix of Any Word in a Sentence
// https://leetcode.com/problems/check-if-a-word-occurs-as-a-prefix-of-any-word-in-a-sentence/
public class S01455
{
    public int IsPrefixOfWord(string sentence, string searchWord)
    {
        var words = sentence.Split(' ');

        for (var i = 0; i < words.Length; i++)
        {
            if (words[i].StartsWith(searchWord))
            {
                return i + 1;
            }
        }

        return -1;
    }
}