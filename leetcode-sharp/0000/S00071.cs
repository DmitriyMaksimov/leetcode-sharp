using System.Text;

namespace leetcode_sharp._0000;

// 71. Simplify Path
// https://leetcode.com/problems/simplify-path/
public class S00071
{
    public string SimplifyPath(string path)
    {
        var stack = new Stack<string>();

        foreach (var part in path.Split("/", StringSplitOptions.RemoveEmptyEntries))
        {
            if (stack.Any() && part == "..")
            {
                stack.Pop();
            }
            else if (part != "." && part != "..")
            {
                stack.Push(part);
            }
        }

        return "/" + string.Join("/", stack.Reverse());
    }
}