namespace leetcode_sharp;

// 2938. Separate Black and White Balls
// https://leetcode.com/problems/separate-black-and-white-balls
public class S02938
{
    public long MinimumSteps(string s)
    {
        var result = 0L;
        var count = 0;

        foreach (var ch in s)
        {
            if (ch == '1')
            {
                ++count;
            }
            else
            {
                result += count;
            }
        }

        return result;
    }
}
