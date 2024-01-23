namespace leetcode_sharp;

// 3014. Minimum Number of Pushes to Type Word I
// https://leetcode.com/problems/minimum-number-of-pushes-to-type-word-i
public class S03014
{
    public int MinimumPushes(string word)
    {
        var n = word.Length;

        var quotient = n / 8;
        var remainder = n % 8;

        return quotient * (quotient + 1) / 2 * 8 + remainder * (quotient + 1);
    }
}