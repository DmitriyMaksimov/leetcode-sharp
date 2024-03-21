namespace leetcode_sharp;

// 1529. Minimum Suffix Flips
// https://leetcode.com/problems/minimum-suffix-flips
public class S01529
{
    public int MinFlips(string target)
    {
        var count = 0;
        var state = 0;

        foreach (var b in target.Where(b => b - '0' != state))
        {
            state = b - '0';
            ++count;
        }

        return count;
    }
}