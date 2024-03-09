namespace leetcode_sharp;

// 2900. Longest Unequal Adjacent Groups Subsequence I
// https://leetcode.com/problems/longest-unequal-adjacent-groups-subsequence-i
public class S02900
{
    public IList<string> GetLongestSubsequence(string[] words, int[] groups)
    {
        List<string> result = [words[0]];
        var previous = groups[0];
        
        for (var i = 1; i < words.Length; ++i)
        {
            if (previous == groups[i]) continue;
            
            previous = groups[i];
            result.Add(words[i]);
        }

        return result;
    }
}