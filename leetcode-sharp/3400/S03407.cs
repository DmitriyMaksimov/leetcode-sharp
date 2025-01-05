namespace leetcode_sharp;

// 3407. Substring Matching Pattern
// https://leetcode.com/problems/substring-matching-pattern
public class S03407
{
    public bool HasMatch(string s, string p)
    {
        var patterns = p.Split('*');
        var index = s.IndexOf(patterns[0], StringComparison.Ordinal);

        if (index == -1)
        {
            return false;
        }

        index = s.IndexOf(patterns[1], index + patterns[0].Length, StringComparison.Ordinal);

        return index != -1;
    }
}
