using System.Text;

namespace leetcode_sharp;

// 1048. Longest String Chain
// https://leetcode.com/problems/longest-string-chain/
public class S01048
{
    public int LongestStrChain(string[] words)
    {
        var dp = new Dictionary<string, int>();
        var res = 0;

        Array.Sort(words, (a, b) => a.Length - b.Length);
        
        foreach (var word in words)
        {
            var max = 0;

            for (var i = 0; i < word.Length; i++)
            {
                var sb = new StringBuilder(word);
                sb.Remove(i, 1);
                var prev = sb.ToString();
                if (dp.TryGetValue(prev, out var value))
                {
                    max = Math.Max(max, value);
                }
            }

            dp[word] = max + 1;

            res = Math.Max(res, dp[word]);
        }

        return res;
    }
}