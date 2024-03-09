namespace leetcode_sharp;

// 3042. Count Prefix and Suffix Pairs I
// https://leetcode.com/problems/count-prefix-and-suffix-pairs-i
public class S03042
{
    public int CountPrefixSuffixPairs(string[] words)
    {
        var result = 0;
        
        for (var i = 0; i < words.Length; ++i)
        {
            for (var j = i + 1; j < words.Length; ++j)
            {
                if (words[i] == words[j].Substring(0, Math.Min(words[i].Length, words[j].Length)) &&
                    words[i] == words[j].Substring(words[j].Length - words[i].Length))
                {
                    result++;
                }
            }
        }

        return result;
    }
}