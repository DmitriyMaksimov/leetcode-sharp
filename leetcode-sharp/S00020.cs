namespace leetcode_sharp;

// 20. Valid Parentheses
// https://leetcode.com/problems/valid-parentheses/
public class S00020
{
    public bool IsValid(string s)
    {
        var stack = new Stack<int>();
        foreach (var ch in s)
        {
            if (ch is '(' or '[' or '{')
            {
                stack.Push(ch);
            }
            else
            {
                if (!stack.TryPop(out var pair)) return false;

                switch (ch)
                {
                    case ')':
                        if (pair != '(') return false;
                        break;
                    case ']':
                        if (pair != '[') return false;
                        break;
                    case '}':
                        if (pair != '{') return false;
                        break;
                }
            }
        }

        return stack.Count == 0;
    }
}