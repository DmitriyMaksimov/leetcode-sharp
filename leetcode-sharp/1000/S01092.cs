using System.Text;

namespace leetcode_sharp;

// 1092. Shortest Common Supersequence
// https://leetcode.com/problems/shortest-common-supersequence
public class S01092
{
    public string ShortestCommonSupersequence(string str1, string str2)
    {
        var m = str1.Length;
        var n = str2.Length;
        var dp = new int[m + 1, n + 1];

        for (var i = 0; i < m; ++i)
        {
            for (var j = 0; j < n; ++j)
            {
                if (str1[i] == str2[j])
                {
                    dp[i + 1, j + 1] = dp[i, j] + 1;
                }
                else
                {
                    dp[i + 1, j + 1] = Math.Max(dp[i + 1, j], dp[i, j + 1]);
                }
            }
        }

        var sb = new StringBuilder();
        var x = m - 1;
        var y = n - 1;

        while (x >= 0 || y >= 0)
        {
            if (x < 0 ^ y < 0)
            {
                var c = x < 0 ? str2[y--] : str1[x--];
                sb.Append(c);
            }
            else if (str1[x] == str2[y])
            {
                sb.Append(str1[x]);
                x--;
                y--;
            }
            else
            {
                var c = dp[x, y + 1] > dp[x + 1, y] ? str1[x--] : str2[y--];
                sb.Append(c);
            }
        }

        return new string(sb.ToString().Reverse().ToArray());
    }
}
