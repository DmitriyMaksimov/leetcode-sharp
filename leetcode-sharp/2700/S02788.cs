namespace leetcode_sharp;

// 2788. Split Strings by Separator
// https://leetcode.com/problems/split-strings-by-separator
public class S02788
{
    public IList<string> SplitWordsBySeparator(IList<string> words, char separator)
    {
        return words.SelectMany(word => word.Split(separator, StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries)).ToList();
    }
}