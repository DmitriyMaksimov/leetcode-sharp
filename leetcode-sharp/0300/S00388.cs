namespace leetcode_sharp;

// 388. Longest Absolute File Path
// https://leetcode.com/problems/longest-absolute-file-path
public class S00388
{
    public int LengthLongestPath(string input)
    {
        var stack = new Stack<int>();
        stack.Push(0);
        var result = 0;

        foreach (var line in input.Split('\n'))
        {
            var level = line.LastIndexOf('\t') + 1;
            while (stack.Count > level + 1)
            {
                stack.Pop();
            }

            var len = stack.Peek() + line.Length - level + 1;
            stack.Push(len);

            if (line.Contains('.'))
            {
                result = Math.Max(result, len - 1);
            }
        }

        return result;
    }
}