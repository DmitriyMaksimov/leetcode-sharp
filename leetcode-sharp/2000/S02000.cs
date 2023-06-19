namespace leetcode_sharp;

// 2000. Reverse Prefix of Word
// https://leetcode.com/problems/reverse-prefix-of-word/
public class S02000
{
    public string ReversePrefix(string word, char ch)
    {
        var index = word.IndexOf(ch);
        return index < 0 ? word : new string(word[..(index + 1)].Reverse().Concat(word[(index + 1)..]).ToArray());
    }
}