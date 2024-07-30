namespace leetcode_sharp;

// 1653. Minimum Deletions to Make String Balanced
// https://leetcode.com/problems/minimum-deletions-to-make-string-balanced
public class S01653
{
    public int MinimumDeletions(string s)
    {
        Stack<char> st = [];
        var result = 0;

        for (var i = s.Length - 1; i >= 0; i--)
        {
            var c = s[i];
            if (st.Count != 0 && st.Peek() < c)
            {
                result++;
                st.Pop();
            }
            else
            {
                st.Push(c);
            }
        }

        return result;
    }
}