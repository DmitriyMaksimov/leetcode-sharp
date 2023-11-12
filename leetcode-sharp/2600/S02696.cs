namespace leetcode_sharp;

// 2696. Minimum String Length After Removing Substrings
// https://leetcode.com/problems/minimum-string-length-after-removing-substrings
public class S02696
{
    public int MinLength(string s)
    {
        var match = new Dictionary<char, char>
        {
            {'B', 'A'}, {'D', 'C'}
        };

        var stack = new Stack<char>();

        foreach (var ch in s)
        {
            if (stack.Count > 0 && match.TryGetValue(ch, out var value))
            {
                if (value == stack.Peek())
                {
                    stack.Pop();
                    continue;
                }
            }

            stack.Push(ch);
        }

        return stack.Count;
    }
}