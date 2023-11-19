namespace leetcode_sharp;

// 2937. Make Three Strings Equal
// https://leetcode.com/problems/make-three-strings-equal
public class S02937
{
    public int FindMinimumOperations(string s1, string s2, string s3)
    {
        var minLen = Math.Min(s1.Length, Math.Min(s2.Length, s3.Length));
        var totalLen = s1.Length + s2.Length + s3.Length;

        if (s1[0] != s2[0] || s1[0] != s3[0] || s2[0] != s3[0])
        {
            return -1;
        }

        for (var i = 0; i < minLen; i++)
        {
            if (s1[i] == s2[i] && s2[i] == s3[i])
            {
                totalLen -= 3;
            }
            else
            {
                break;
            }
        }

        return totalLen;
    }
}