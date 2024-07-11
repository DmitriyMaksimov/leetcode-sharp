namespace leetcode_sharp;

// 1190. Reverse Substrings Between Each Pair of Parentheses
// https://leetcode.com/problems/reverse-substrings-between-each-pair-of-parentheses
public class S01190
{
    public string ReverseParentheses(string s)
    {
        var stack = new Stack<string>();
        var str = "";

        foreach (var ch in s)
        {
            switch (ch)
            {
                case ')':
                {
                    var p = stack.Pop();
                    var r = new string(str.Reverse().ToArray());
                    str = p + r;
                    break;
                }
                case '(':
                    stack.Push(str);
                    str = "";
                    break;
                default:
                    str += ch;
                    break;
            }
        }

        return str;
    }
}