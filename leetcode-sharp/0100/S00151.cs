namespace leetcode_sharp;

// 151. Reverse Words in a String
// https://leetcode.com/problems/reverse-words-in-a-string/
public class S00151
{
    public string ReverseWords(string s)
    {
        return string.Join(' ', s.Split(' ', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries).AsEnumerable().Reverse());
    }
}