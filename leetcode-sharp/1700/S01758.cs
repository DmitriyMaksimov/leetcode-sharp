namespace leetcode_sharp;

// 1758. Minimum Changes To Make Alternating Binary String
// https://leetcode.com/problems/minimum-changes-to-make-alternating-binary-string/
public class S01758
{
    public int MinOperations(string s)
    {
        var count = s.Where((t, i) => t - '0' != i % 2).Count();

        return Math.Min(count, s.Length - count);
    }
}