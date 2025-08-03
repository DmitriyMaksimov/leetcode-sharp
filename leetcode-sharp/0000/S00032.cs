namespace leetcode_sharp;

// 32. Longest Valid Parentheses
// https://leetcode.com/problems/longest-valid-parentheses/
public class S00032
{
    public int LongestValidParentheses(string s)
    {
        var stack = new Stack<int>();
        var res = 0;

        for (int i = 0, pv = 0; i < s.Length; ++i)
        {
            if (s[i] == '(')
            {
                stack.Push(pv);
            }
            else if (stack.Count != 0)
            {
                res = Math.Max(res, i - (pv = stack.Pop()) + 1);
                continue;
            }

            pv = i + 1;
        }

        return res;
    }
}