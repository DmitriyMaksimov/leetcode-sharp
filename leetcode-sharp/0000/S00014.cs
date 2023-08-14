namespace leetcode_sharp;

// 14. Longest Common Prefix
// https://leetcode.com/problems/longest-common-prefix/
public class S00014
{
    public string LongestCommonPrefix(string[] strs)
    {
        Array.Sort(strs);
        
        var s1 = strs[0];
        var s2 = strs[^1];
        var index = 0;

        while (index < s1.Length && index < s2.Length)
        {
            if (s1[index] != s2[index])
            {
                break;
            }

            index++;
        }

        return s1[..index];
    }
}