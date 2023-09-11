namespace leetcode_sharp;

// 1790. Check if One String Swap Can Make Strings Equal
// https://leetcode.com/problems/check-if-one-string-swap-can-make-strings-equal/
public class S01790
{
    public bool AreAlmostEqual(string s1, string s2)
    {
        if (s1.Length != s2.Length)
        {
            return false;
        }

        var diff = new List<int>();

        for (var i = 0; i < s1.Length; i++)
        {
            if (s1[i] == s2[i]) continue;
            
            diff.Add(i);
            if (diff.Count > 2)
            {
                return false;
            }
        }

        if (diff.Count == 0)
        {
            return true;
        }

        if (diff.Count != 2)
        {
            return false;
        }

        var i1 = diff[0];
        var i2 = diff[1];

        return s1[i1] == s2[i2] && s1[i2] == s2[i1];
    }
}