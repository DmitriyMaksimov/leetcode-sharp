namespace leetcode_sharp;

// 2707. Extra Characters in a String
// https://leetcode.com/problems/extra-characters-in-a-string/ 
public class S02707
{
    public int MinExtraChar(string s, string[] dictionary)
    {
        var maxVal = s.Length + 1;
        var dp = new int[s.Length + 1];
        Array.Fill(dp, maxVal);
        dp[0] = 0;

        var dictionarySet = new HashSet<string>(dictionary);

        for (var i = 1; i <= s.Length; ++i)
        {
            dp[i] = dp[i - 1] + 1;
            for (var j = 1; j <= i; ++j)
            {
                if (dictionarySet.Contains(s.Substring(i - j, j)))
                {
                    dp[i] = Math.Min(dp[i], dp[i - j]);
                }
            }
        }

        return dp[s.Length];
    }
}