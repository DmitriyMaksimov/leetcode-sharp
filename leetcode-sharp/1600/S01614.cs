namespace leetcode_sharp;

// 1614. Maximum Nesting Depth of the Parentheses
// https://leetcode.com/problems/maximum-nesting-depth-of-the-parentheses/
public class S01614
{
    public int MaxDepth(string s)
    {
        var count = 0;
        var result = 0;

        foreach (var ch in s)
        {
            if (ch == '(')
            {
                ++count;
            }
            else if (ch == ')')
            {
                result = Math.Max(result, count);
                --count;
            }
        }

        return result;
    }
}