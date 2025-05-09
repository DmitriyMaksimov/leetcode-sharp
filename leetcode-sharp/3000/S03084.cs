namespace leetcode_sharp;

// 3084. Count Substrings Starting and Ending with Given Character
// https://leetcode.com/problems/count-substrings-starting-and-ending-with-given-character
public class S03084
{
    public long CountSubstrings(string s, char c)
    {
        var count = 0;
        var result = 0L;

        foreach (var ch in s.Where(ch => ch == c))
        {
            count++;
            result += count;
        }

        return result;
    }
}
