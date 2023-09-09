using System.Text;

namespace leetcode_sharp;

// 1544. Make The String Great
// https://leetcode.com/problems/make-the-string-great/
public class S01544
{
    public string MakeGood(string s)
    {
        var stack = new Stack<char>();
        foreach (var c in s)
        {
            if (stack.Count > 0 && stack.Peek() != c && char.ToLower(stack.Peek()) == char.ToLower(c))
            {
                stack.Pop();
            }
            else
            {
                stack.Push(c);
            }
        }

        var sb = new StringBuilder();
        while (stack.Count > 0)
        {
            sb.Append(stack.Pop());
        }

        return new string(sb.ToString().Reverse().ToArray());
    }
}