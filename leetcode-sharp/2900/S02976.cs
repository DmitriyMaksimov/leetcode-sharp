namespace leetcode_sharp;

// 2976. Minimum Cost to Convert String I
// https://leetcode.com/problems/minimum-cost-to-convert-string-i
public class S02976
{
    public long MinimumCost(string source, string target, char[] original, char[] changed, int[] cost)
    {
        const int maxLetters = 26;
        
        var d = new long[maxLetters][];

        for (var i = 0; i < maxLetters; i++)
        {
            d[i] = new long[maxLetters];
            Array.Fill(d[i], int.MaxValue);
        }

        for (var i = 0; i < original.Length; ++i)
        {
            var s = original[i] - 'a';
            var t = changed[i] - 'a';
            d[s][t] = Math.Min(d[s][t], cost[i]);
        }

        for (var k = 0; k < maxLetters; ++k)
        {
            for (var i = 0; i < maxLetters; ++i)
            {
                for (var j = 0; j < maxLetters; ++j)
                {
                    d[i][j] = Math.Min(d[i][j], d[i][k] + d[k][j]);
                }
            }
        }

        long result = 0;

        for (var i = 0; i < source.Length; ++i)
        {
            if (source[i] == target[i])
            {
                continue;
            }

            int s = source[i] - 'a', t = target[i] - 'a';
            if (d[s][t] >= int.MaxValue)
            {
                return -1;
            }

            result += d[s][t];
        }

        return result;
    }
}