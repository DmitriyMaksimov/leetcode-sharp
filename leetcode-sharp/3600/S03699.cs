namespace leetcode_sharp;

// 3699. Number of ZigZag Arrays I
// https://leetcode.com/problems/number-of-zigzag-arrays-i
public class S03699
{
    public int ZigZagArrays(int n, int l, int r)
    {
        const int mod = 1_000_000_007;

        var range = r - l;
        var dp = Enumerable.Repeat(1, range + 1).ToArray();

        for (var step = 1; step < n; step++)
        {
            var prefixSum = 0;

            if ((step & 1) == 1)
            {
                for (var value = 0; value <= range; value++)
                {
                    var nextPrefix = (prefixSum + dp[value]) % mod;
                    dp[value] = prefixSum;
                    prefixSum = nextPrefix;
                }
            }
            else
            {
                for (var value = range; value >= 0; value--)
                {
                    var nextPrefix = (prefixSum + dp[value]) % mod;
                    dp[value] = prefixSum;
                    prefixSum = nextPrefix;
                }
            }
        }

        var result = 0L;

        foreach (var count in dp)
        {
            result += count;
            result %= mod;
        }

        return (int)(result * 2 % mod);
    }
}