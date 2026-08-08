namespace leetcode_sharp;

// 3302. Find the Lexicographically Smallest Valid Sequence
// https://leetcode.com/problems/find-the-lexicographically-smallest-valid-sequence
public class S03302
{
    public int[] ValidSequence(string word1, string word2)
    {
        var n = word1.Length;
        var m = word2.Length;
        var last = Enumerable.Repeat(-1, m).ToArray();

        for (int i = n - 1, k = m - 1; i >= 0; --i)
        {
            if (k >= 0 && word1[i] == word2[k])
            {
                last[k--] = i;
            }
        }

        var j = 0;
        var result = new int[m];
        var skip = 0;

        for (var i = 0; i < n && j < m; ++i)
        {
            if (word1[i] == word2[j] || (skip == 0 && (j == m - 1 || i < last[j + 1])))
            {
                result[j] = i;

                if (word1[i] != word2[j])
                {
                    skip++;
                }

                j++;
            }
        }

        return j == m ? result : [];
    }
}