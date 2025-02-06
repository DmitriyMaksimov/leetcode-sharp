namespace leetcode_sharp;

// 792. Number of Matching Subsequences
// https://leetcode.com/problems/number-of-matching-subsequences
public class S00792
{
    public int NumMatchingSubseq(string s, string[] words)
    {
        var wordDict = new Dictionary<char, List<string>>();

        foreach (var c in s)
        {
            wordDict[c] = [];
        }

        foreach (var word in words)
        {
            wordDict.TryAdd(word[0], []);
            wordDict[word[0]].Add(word);
        }

        var count = 0;

        foreach (var c in s)
        {
            if (!wordDict.TryGetValue(c, out var value))
            {
                continue;
            }

            var wordsExpectingChar = new List<string>(value);
            wordDict[c].Clear();

            foreach (var word in wordsExpectingChar)
            {
                if (word.Length == 1)
                {
                    count++;
                }
                else
                {
                    var nextChar = word[1];
                    wordDict.TryAdd(nextChar, []);
                    wordDict[nextChar].Add(word.Substring(1));
                }
            }
        }

        return count;
    }
}
