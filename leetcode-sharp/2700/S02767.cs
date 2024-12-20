namespace leetcode_sharp;

// 2767. Partition String Into Minimum Beautiful Substrings
// https://leetcode.com/problems/partition-string-into-minimum-beautiful-substrings
public class S02767
{
    private readonly HashSet<int> _powersOf5 = [1, 5, 25, 125, 625, 3125, 15625];

    private int Dfs(int i, int val, string s)
    {
        if (i == s.Length)
        {
            return val == 0 ? 0 : 16;
        }

        val = val * 2 + (s[i] - '0');

        if (val == 0)
        {
            return s.Length + 1;
        }

        return Math.Min(Dfs(i + 1, val, s), (_powersOf5.Contains(val) ? Dfs(i + 1, 0, s) : s.Length) + 1);
    }

    public int MinimumBeautifulSubstrings(string s)
    {
        var result = Dfs(0, 0, s);
        return result > s.Length ? -1 : result;
    }
}
