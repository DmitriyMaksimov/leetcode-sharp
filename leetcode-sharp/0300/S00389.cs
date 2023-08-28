namespace leetcode_sharp;

// 389. Find the Difference
// https://leetcode.com/problems/find-the-difference/
public class S00389
{
    public char FindTheDifference(string s, string t)
    {
        var s1 = s.ToCharArray();
        var t1 = t.ToCharArray();
        
        Array.Sort(s1);
        Array.Sort(t1);

        for (var i = 0; i < s1.Length; i++)
        {
            if (s1[i] != t1[i])
            {
                return t1[i];
            }
        }

        return t1[^1];
    }
}