namespace leetcode_sharp;

// 2901. Longest Unequal Adjacent Groups Subsequence II
// https://leetcode.com/problems/longest-unequal-adjacent-groups-subsequence-ii
public class S02901
{
    public IList<string> GetWordsInLongestSubsequence(string[] words, int[] groups)
    {
        var n = groups.Length;
        var dp = Enumerable.Repeat(1, n).ToArray();
        var parent = Enumerable.Repeat(-1, n).ToArray();
        var maxi = 0;
        var maxIndex = -1;

        for (var i = 0; i < n; i++)
        {
            for (var j = 0; j < i; j++)
            {
                if (groups[i] != groups[j] && HammingDistanceIsOne(words[i], words[j]) && dp[i] < dp[j] + 1)
                {
                    dp[i] = dp[j] + 1;
                    parent[i] = j;
                }
            }

            if (dp[i] > maxi)
            {
                maxi = dp[i];
                maxIndex = i;
            }
        }

        var result = new List<string>();

        for (var i = maxIndex; i != -1; i = parent[i])
        {
            result.Add(words[i]);
        }

        result.Reverse();
        return result;
    }

    private static bool HammingDistanceIsOne(string word1, string word2)
    {
        if (word1.Length != word2.Length)
        {
            return false;
        }

        var diffCount = word1.Where((t, i) => t != word2[i]).Count();

        return diffCount == 1;
    }
}
