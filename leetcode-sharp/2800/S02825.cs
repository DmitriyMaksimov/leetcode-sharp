namespace leetcode_sharp;

// 2825. Make String a Subsequence Using Cyclic Increments
// https://leetcode.com/problems/make-string-a-subsequence-using-cyclic-increments
public class S02825
{
    public bool CanMakeSubsequence(string str1, string str2)
    {
        var i = 0;
        var j = 0;

        while (i < str1.Length && j < str2.Length)
        {
            if (str1[i] - 'a' == str2[j] - 'a' || (str1[i] - 'a' + 1) % 26 == str2[j] - 'a')
            {
                j++;
            }

            if (j == str2.Length)
            {
                return true;
            }

            i++;
        }

        return false;
    }
}
