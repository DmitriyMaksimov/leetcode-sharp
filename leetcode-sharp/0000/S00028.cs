namespace leetcode_sharp;

// 28. Find the Index of the First Occurrence in a String
// https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string/
public class S00028
{
    public int StrStr(string haystack, string needle)
    {
        return haystack.IndexOf(needle, StringComparison.Ordinal);
    }
}