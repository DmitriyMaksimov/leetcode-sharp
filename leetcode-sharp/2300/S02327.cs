namespace leetcode_sharp;

// 2327. Number of People Aware of a Secret
// https://leetcode.com/problems/number-of-people-aware-of-a-secret
public class S02327
{
    private const int Mod = 1_000_000_007;

    public int PeopleAwareOfSecret(int n, int delay, int forget)
    {
        var memo = Enumerable.Repeat(1, n + 1).ToArray();
        memo[0] = 0;

        for (var i = 1; i <= n; i++)
        {
            for (var j = delay; j < forget; j++)
            {
                if (i - j >= 0)
                {
                    memo[i] = (memo[i] + memo[i - j]) % Mod;
                }
            }
        }

        return (memo[n] - memo[n - forget] + Mod) % Mod;
    }
}