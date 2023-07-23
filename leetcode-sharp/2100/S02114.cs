namespace leetcode_sharp;

// 2114. Maximum Number of Words Found in Sentences
// https://leetcode.com/problems/maximum-number-of-words-found-in-sentences/
public class S02114
{
    public int MostWordsFound(string[] sentences)
    {
        return sentences.Max(x => x.Count(c => c == ' ')) + 1;
    }
}