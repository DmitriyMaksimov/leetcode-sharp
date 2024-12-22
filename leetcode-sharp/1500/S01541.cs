namespace leetcode_sharp;

// 1541. Minimum Insertions to Balance a Parentheses String
// https://leetcode.com/problems/minimum-insertions-to-balance-a-parentheses-string
public class S01541
{
    public int MinInsertions(string s)
    {
        var result = 0;
        var t = new Stack<int>();

        foreach (var c in s)
        {
            if (c == '(')
            {
                if (t.Count == 0 || t.Peek() == 2)
                {
                    t.Push(2);
                }
                else
                {
                    t.Pop();
                    t.Push(2);
                    result++;
                }
            }
            else
            {
                if (t.Count == 0)
                {
                    t.Push(1);
                    result++;
                }
                else if (t.Peek() == 1)
                {
                    t.Pop();
                }
                else if (t.Peek() == 2)
                {
                    t.Pop();
                    t.Push(1);
                }
            }
        }

        while (t.Count > 0)
        {
            result += t.Pop();
        }

        return result;
    }
}
