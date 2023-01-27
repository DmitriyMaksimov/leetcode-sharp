namespace leetcode_sharp;

// 472. Concatenated Words
// https://leetcode.com/problems/concatenated-words/
public class S00472
{
    public IList<string> FindAllConcatenatedWordsInADict(string[] words)
    {
        var result = new List<string>();
        var dictionary = words.ToHashSet();

        foreach (var word in words)
        {
            var length = word.Length;
            var dp = new bool[length + 1];
            dp[0] = true;
            for (var i = 1; i <= length; ++i)
            {
                for (var j = i == length ? 1 : 0; !dp[i] && j < i; ++j)
                {
                    dp[i] = dp[j] && dictionary.Contains(word[j..i]);
                }
            }

            if (dp[length])
            {
                result.Add(word);
            }
        }

        return result;
    }
}