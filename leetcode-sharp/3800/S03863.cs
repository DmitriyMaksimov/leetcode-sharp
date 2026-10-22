namespace leetcode_sharp;

// 3863. Minimum Operations to Sort a String
// https://leetcode.com/problems/minimum-operations-to-sort-a-string
public class S03863
{
    public int MinOperations(string s)
    {
        if (IsSorted(s))
        {
            return 0;
        }

        if (s.Length == 2)
        {
            return -1;
        }

        var minP = s.Skip(1).Take(s.Length - 2).Min();
        var maxP = s.Skip(1).Take(s.Length - 2).Max();

        if (s[0] <= s[^1] && (minP >= s[0] || maxP <= s[^1]))
        {
            return 1;
        }

        return s[^1] < minP && s[0] > maxP ? 3 : 2;
    }

    private bool IsSorted(string s)
    {
        for (int i = 1; i < s.Length; i++)
        {
            if (s[i] < s[i - 1])
            {
                return false;
            }
        }

        return true;
    }
}