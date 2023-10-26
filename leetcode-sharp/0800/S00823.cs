namespace leetcode_sharp;

// 823. Binary Trees With Factors
// https://leetcode.com/problems/binary-trees-with-factors
public class S00823
{
    private const int Mod = 1_000_000_007;

    public int NumFactoredBinaryTrees(int[] arr)
    {
        Array.Sort(arr);
        var s = new HashSet<int>(arr);
        var dp = new Dictionary<int, long>();
        foreach (var x in arr)
        {
            dp[x] = 1;
        }

        foreach (var i in arr)
        {
            foreach (var j in arr)
            {
                if (j > Math.Sqrt(i)) break;
                if (i % j == 0 && s.Contains(i / j))
                {
                    var temp = dp[j] * dp[i / j];
                    dp[i] = (dp[i] + (i / j == j ? temp : temp * 2)) % Mod;
                }
            }
        }

        var result = 0L;

        foreach (var val in dp.Values)
        {
            result = (result + val) % Mod;
        }

        return (int) result;
    }
}