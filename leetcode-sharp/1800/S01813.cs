namespace leetcode_sharp;

// 1813. Sentence Similarity III
// https://leetcode.com/problems/sentence-similarity-iii
public class S01813
{
    public bool AreSentencesSimilar(string sentence1, string sentence2)
    {
        var words1 = sentence1.Split(" ");
        String[] words2 = sentence2.Split(" ");
        var n1 = words1.Length;
        var n2 = words2.Length;

        if (n1 > n2)
        {
            return AreSentencesSimilar(sentence2, sentence1);
        }

        var i = 0;

        while (i < n1 && words1[i].Equals(words2[i]))
        {
            ++i;
        }

        while (i < n1 && words1[i].Equals(words2[n2 - n1 + i]))
        {
            ++i;
        }

        return i == n1;
    }
}
