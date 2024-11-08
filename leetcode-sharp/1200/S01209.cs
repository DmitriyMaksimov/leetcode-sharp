using System.Text;

namespace leetcode_sharp;

// 1209. Remove All Adjacent Duplicates in String II
// https://leetcode.com/problems/remove-all-adjacent-duplicates-in-string-ii
public class S01209
{
    public string RemoveDuplicates(string s, int k)
    {
        var stack = new Stack<(char Ch, int Count)>();

        foreach (var c in s)
        {
            if (stack.Count > 0 && stack.Peek().Ch == c)
            {
                var (ch, count) = stack.Pop();
                if (count + 1 < k)
                {
                    stack.Push((ch, count + 1));
                }
            }
            else
            {
                stack.Push((c, 1));
            }
        }

        var sb = new StringBuilder();
        while (stack.Count > 0)
        {
            var (c, count) = stack.Pop();
            for (var i = 0; i < count; i++)
            {
                sb.Append(c);
            }
        }

        return new string(sb.ToString().Reverse().ToArray());
    }
}