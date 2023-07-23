namespace leetcode_sharp;

// 1816. Truncate Sentence
// https://leetcode.com/problems/truncate-sentence/
public class S01816
{
    public string TruncateSentence(string s, int k)
    {
        return string.Join(" ", s.Split(" ").Take(k));
    }
}