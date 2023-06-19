namespace leetcode_sharp;

// 2185. Counting Words With a Given Prefix
// https://leetcode.com/problems/counting-words-with-a-given-prefix/
public class S02185
{
    public int PrefixCount(string[] words, string pref)
    {
        return words.Count(x => x.StartsWith(pref));
    }
}