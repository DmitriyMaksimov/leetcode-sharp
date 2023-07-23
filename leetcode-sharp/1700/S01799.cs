namespace leetcode_sharp;

// 1799. Maximize Score After N Operations
// https://leetcode.com/problems/maximize-score-after-n-operations/
public class S01799
{
    public int MaxScore(int[] nums)
    {
        var n = nums.Length;
        var gcdVal = new Dictionary<int, int>();
        
        for (var i = 0; i < n; ++i)
        {
            for (var j = i + 1; j < n; ++j)
            {
                gcdVal.Add((1 << i) + (1 << j), gcd(nums[i], nums[j]));
            }
        }

        var dp = new int[1 << n];

        for (var i = 0; i < 1 << n; ++i)
        {
            var bits = System.Numerics.BitOperations.PopCount((uint) i);
            if (bits % 2 != 0)
            {
                // Skip odd numbers
                continue;
            }

            foreach (var (k, v) in gcdVal)
            {
                if ((k & i) != 0)
                {
                    // Skip overlapping numbers
                    continue;
                }

                dp[i ^ k] = Math.Max(dp[i ^ k], dp[i] + v * (bits / 2 + 1));
            }
        }

        return dp[(1 << n) - 1];
    }

    private static int gcd(int a, int b)
    {
        return b == 0 ? a : gcd(b, a % b);
    }
}