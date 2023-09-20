namespace leetcode_sharp;

// 2255. Count Prefixes of a Given String
// https://leetcode.com/problems/count-prefixes-of-a-given-string/
public class S02255
{
    public int CountPrefixes(string[] words, string s)
    {
        return words.Count(s.StartsWith);
    }
}