using System.Text;

namespace leetcode_sharp;

// 1021. Remove Outermost Parentheses
// https://leetcode.com/problems/remove-outermost-parentheses/
public class S01021
{
    public string RemoveOuterParentheses(string s)
    {
        var sb = new StringBuilder();
        var opened = 0;

        foreach (var c in s)
        {
            if (c == '(' && opened++ > 0)
            {
                sb.Append(c);
            }

            if (c == ')' && opened-- > 1)
            {
                sb.Append(c);
            }
        }
        
        return sb.ToString();
    }
}