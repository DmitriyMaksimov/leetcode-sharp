namespace leetcode_sharp;

// 1717. Maximum Score From Removing Substrings
// https://leetcode.com/problems/maximum-score-from-removing-substrings
public class S01717
{
    public int MaximumGain(string s, int x, int y)
    {
        var stack = new Stack<char>();
        var stack2 = new Stack<char>();
        var max = Math.Max(x, y);
        var min = Math.Min(x, y);
        var first = x > y ? 'a' : 'b';
        var second = x > y ? 'b' : 'a';
        var result = 0;

        foreach (var c in s)
        {
            if (stack.Count != 0 && stack.Peek() == first && c == second)
            {
                stack.Pop();
                result += max;
            }
            else
            {
                stack.Push(c);
            }
        }

        while (stack.Count != 0)
        {
            char c = stack.Pop();
            if (stack2.Count != 0 && stack2.Peek() == first && c == second)
            {
                stack2.Pop();
                result += min;
            }
            else
            {
                stack2.Push(c);
            }
        }

        return result;
    }
}