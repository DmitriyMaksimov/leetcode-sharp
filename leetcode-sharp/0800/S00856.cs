namespace leetcode_sharp;

// 856. Score of Parentheses
// https://leetcode.com/problems/score-of-parentheses
public class S00856
{
    public int ScoreOfParentheses(string s)
    {
        Stack<int> stack = [];
        var current = 0;

        foreach (var c in s)
        {
            if (c == '(')
            {
                stack.Push(current);
                current = 0;
            }
            else
            {
                current = stack.Pop() + Math.Max(current * 2, 1);
            }
        }

        return current;
    }
}
