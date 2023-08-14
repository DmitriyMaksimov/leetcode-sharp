namespace leetcode_sharp;

// 97. Interleaving String
// https://leetcode.com/problems/interleaving-string/
public class S00097
{
    public bool IsInterleave(string s1, string s2, string s3)
    {
        return s3.Length == s1.Length + s2.Length && helper(s1, s2, s3, s1.Length - 1, s2.Length - 1, s3.Length - 1);
    }

    private static bool helper(string s1, string s2, string s3, int l1, int l2, int l3)
    {
        switch (l1)
        {
            case < 0 when l2 < 0 && l3 < 0:
                return true;

            case >= 0 when s1[l1] == s3[l3] && l2 >= 0 && s2[l2] == s3[l3]:
                return helper(s1, s2, s3, l1 - 1, l2, l3 - 1) || helper(s1, s2, s3, l1, l2 - 1, l3 - 1);
            
            case >= 0 when s1[l1] == s3[l3]:
                return helper(s1, s2, s3, l1 - 1, l2, l3 - 1);
        }

        if (l2 >= 0 && s2[l2] == s3[l3])
        {
            return helper(s1, s2, s3, l1, l2 - 1, l3 - 1);
        }
        
        return false;
    }
}