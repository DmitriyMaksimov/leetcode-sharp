namespace leetcode_sharp;

// 2745. Construct the Longest New String
// https://leetcode.com/problems/construct-the-longest-new-string
public class S02745
{
    public int LongestString(int x, int y, int z)
    {
        var mn = Math.Min(x, y);

        return x == y ? 4 * x + 2 * z : 2 * mn + (mn + 1) * 2 + 2 * z;
    }
}
