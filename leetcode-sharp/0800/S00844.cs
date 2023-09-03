namespace leetcode_sharp;

// 844. Backspace String Compare
// https://leetcode.com/problems/backspace-string-compare/
public class S00844
{
    public bool BackspaceCompare(string s, string t)
    {
        var s1 = new Stack<char>();
        var t1 = new Stack<char>();

        foreach (var c in s)
        {
            if (c == '#')
            {
                if (s1.Count > 0)
                {
                    s1.Pop();
                }
            }
            else
            {
                s1.Push(c);
            }
        }

        foreach (var c in t)
        {
            if (c == '#')
            {
                if (t1.Count > 0)
                {
                    t1.Pop();
                }
            }
            else
            {
                t1.Push(c);
            }
        }

        return s1.SequenceEqual(t1);
    }
}