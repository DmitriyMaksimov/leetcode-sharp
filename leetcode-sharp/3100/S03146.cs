namespace leetcode_sharp;

// 3146. Permutation Difference between Two Strings
// https://leetcode.com/problems/permutation-difference-between-two-strings
public class S03146
{
    public int FindPermutationDifference(string s, string t)
    {
        const int maxChars = 26;
        var indices = new int[maxChars];
        
        for (var i = 0; i < t.Length; i++)
        {
            indices[t[i] - 'a'] = i;
        }

        var result = 0;

        for (var i = 0; i < s.Length; i++)
        {
            result += Math.Abs(i - indices[s[i] - 'a']);
        }

        return result;
    }
}