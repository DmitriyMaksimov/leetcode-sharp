using System.Text;

namespace leetcode_sharp;

// 1910. Remove All Occurrences of a Substring
// https://leetcode.com/problems/remove-all-occurrences-of-a-substring
public class S01910
{
    public string RemoveOccurrences(string s, string part)
    {
        var st = new Stack<char>();
        var n = s.Length;
        var m = part.Length;
        for (var i = 0; i < n; i++)
        {
            st.Push(s[i]);
            
            if (st.Count < m) continue;
            
            var x = "";
            
            for (var j = m - 1; j >= 0; j--)
            {
                var ch = part[j];
                if (ch != st.Peek())
                {
                    foreach (var c in x)
                    {
                        st.Push(c);
                    }

                    break;
                }

                x = st.Peek() + x;
                st.Pop();
            }
        }

        return new string(st.Reverse().ToArray());
    }
}