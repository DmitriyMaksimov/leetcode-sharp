namespace leetcode_sharp;

// 2911. Minimum Changes to Make K Semi-palindromes
// https://leetcode.com/problems/minimum-changes-to-make-k-semi-palindromes
public class S02911
{
    public int MinimumChanges(string s, int k)
    {
        var n = s.Length;
        const int inf = int.MaxValue / 2;

        var cost = new int[n + 1, n + 1];

        for (var i = 0; i <= n; i++)
        {
            for (var j = 0; j <= n; j++)
            {
                cost[i, j] = inf;
            }
        }

        for (var d = 1; 2 * d <= n; d++)
        {
            for (var length = 2 * d; length <= n; length += d)
            {
                for (int i = 0, j = length; j <= n; i++, j++)
                {
                    cost[i, j] = Math.Min(cost[i, j], Peel(s, i, j, d));
                }
            }
        }

        var best = Enumerable.Repeat(inf, n + 1).ToArray();
        best[0] = 0;

        for (var pieces = 1; pieces < k; pieces++)
        {
            var next = Enumerable.Repeat(inf, n + 1).ToArray();

            for (var j = 2 * pieces; j <= n - 2 * (k - pieces); j++)
            {
                next[j] = Extend(best, cost, j);
            }

            best = next;
        }

        return Extend(best, cost, n);
    }

    private static int Peel(string s, int i, int j, int d)
    {
        var changes = 0;

        while (j - i > d)
        {
            for (var t = 0; t < d; t++)
            {
                if (s[i + t] != s[j - d + t])
                {
                    changes++;
                }
            }

            i += d;
            j -= d;
        }

        return changes;
    }

    private static int Extend(int[] best, int[,] cost, int j)
    {
        var result = int.MaxValue / 2;

        for (var i = 0; i <= j - 2; i++)
        {
            result = Math.Min(result, best[i] + cost[i, j]);
        }

        return result;
    }
}