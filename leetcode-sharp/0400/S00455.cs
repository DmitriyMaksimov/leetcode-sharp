namespace leetcode_sharp;

// 455. Assign Cookies
// https://leetcode.com/problems/assign-cookies/
public class S00455
{
    public int FindContentChildren(int[] g, int[] s)
    {
        Array.Sort(g);
        Array.Sort(s);
        var i = 0;
        var j = 0;
        while (i < g.Length && j < s.Length)
        {
            if (g[i] <= s[j])
            {
                i++;
            }

            j++;
        }

        return i;
    }
}