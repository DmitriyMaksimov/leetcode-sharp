namespace leetcode_sharp;

// 2068. Check if Two String Arrays are Equivalent
// https://leetcode.com/problems/check-if-two-string-arrays-are-equivalent/
public class S02068
{
    public bool CheckAlmostEquivalent(string word1, string word2)
    {
        var a1 = new int[26];
        var a2 = new int[26];

        foreach (var n in word1.ToCharArray())
        {
            a1[n - 'a']++;
        }

        foreach (var n in word2.ToCharArray())
        {
            a2[n - 'a']++;
        }

        return !a1.Where((t, i) => Math.Abs(t - a2[i]) > 3).Any();
    }
}