namespace leetcode_sharp;

// 1832. Check if the Sentence Is Pangram
// https://leetcode.com/problems/check-if-the-sentence-is-pangram/
public class S01832
{
    public bool CheckIfPangram(string sentence)
    {
        const int totalLetters = 26;
        if (sentence.Length < totalLetters)
        {
            return false;
        }

        var chars = new HashSet<char>();

        foreach (var ch in sentence)
        {
            chars.Add(ch);
        }

        return chars.Count == totalLetters;
    }
}