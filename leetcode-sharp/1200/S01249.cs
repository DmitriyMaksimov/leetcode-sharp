using System.Text;

namespace leetcode_sharp;

// 1249. Minimum Remove to Make Valid Parentheses
// https://leetcode.com/problems/minimum-remove-to-make-valid-parentheses
public class S01249
{
    public string MinRemoveToMakeValid(string s)
    {
        Stack<int> st = [];

        for (var i = 0; i < s.Length; i++)
        {
            switch (s[i])
            {
                case '(':
                    st.Push(i);
                    break;
                case ')' when st.Count != 0 && s[st.Peek()] == '(':
                    st.Pop();
                    break;
                case ')':
                    st.Push(i);
                    break;
            }
        }

        var sb = new StringBuilder();

        for (var i = s.Length - 1; i >= 0; i--)
        {
            if (st.Count != 0 && st.Peek() == i)
            {
                st.Pop();
            }
            else
            {
                sb.Append(s[i]);
            }
        }

        return new string(sb.ToString().Reverse().ToArray());
    }
}