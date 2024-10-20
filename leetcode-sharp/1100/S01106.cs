namespace leetcode_sharp;

// 1106. Parsing A Boolean Expression
// https://leetcode.com/problems/parsing-a-boolean-expression
public class S01106
{
    public bool ParseBoolExpr(string expression)
    {
        Stack<char> stack = [];

        foreach (var ch in expression)
        {
            if (ch == ')')
            {
                HashSet<char> innerExpressions = [];
                while (stack.Peek() != '(')
                {
                    innerExpressions.Add(stack.Pop());
                }

                stack.Pop();

                switch (stack.Pop())
                {
                    case '&':
                        // Any `false` makes `&` false
                        stack.Push(innerExpressions.Contains('f') ? 'f' : 't');
                        break;
                    case '|':
                        // Any `true` makes `|` true
                        stack.Push(innerExpressions.Contains('t') ? 't' : 'f');
                        break;
                    case '!':
                        // `!` inverts `true->false` and `false->true`
                        stack.Push(innerExpressions.Contains('t') ? 'f' : 't');
                        break;
                }
            }
            else if (ch != ',')
            {
                stack.Push(ch);
            }
        }

        return stack.Pop() == 't';
    }
}
