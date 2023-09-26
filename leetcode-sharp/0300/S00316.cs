namespace leetcode_sharp;

// 316. Remove Duplicate Letters
// https://leetcode.com/problems/remove-duplicate-letters
public class S00316
{
    public string RemoveDuplicateLetters(string s)
    {
        var stack = new Stack<char>();
        var seen = new HashSet<char>();
        var lastOcc = new Dictionary<char, int>();

        for (var i = 0; i < s.Length; i++)
        {
            lastOcc[s[i]] = i;
        }

        for (var i = 0; i < s.Length; i++)
        {
            var c = s[i];
            if (seen.Contains(c)) continue;

            while (stack.Count > 0 && c < stack.Peek() && i < lastOcc[stack.Peek()])
            {
                seen.Remove(stack.Pop());
            }

            seen.Add(c);
            stack.Push(c);
        }

        return new string(stack.Reverse().ToArray());
    }
}