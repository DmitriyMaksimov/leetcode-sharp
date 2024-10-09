namespace leetcode_sharp;

//
// https://leetcode.com/problems/camelcase-matching
public class S01023
{
    public IList<bool> CamelMatch(string[] queries, string pattern)
    {
        return queries.Select(query => Match(query, pattern)).ToArray();
    }

    private static bool Match(string query, string pattern)
    {
        var i = 0;

        foreach (var ch in query)
        {
            if (i < pattern.Length && ch == pattern[i])
            {
                i++;
            }
            else if (ch is >= 'A' and <= 'Z')
            {
                return false;
            }
        }

        return i == pattern.Length;
    }
}
