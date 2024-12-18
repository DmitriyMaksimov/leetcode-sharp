namespace leetcode_sharp;

// 2712. Minimum Cost to Make All Characters Equal
// https://leetcode.com/problems/minimum-cost-to-make-all-characters-equal
public class S02712
{
    public long MinimumCost(string s)
    {
        var result = 0L;
        var n = s.Length;

        for (var i = 1; i < n; i++)
        {
            if (s[i] != s[i - 1])
            {
                result += Math.Min(i, n - i);
            }
        }

        return result;
    }
}
