namespace leetcode_sharp;

// 3179. Find the N-th Value After K Seconds
// https://leetcode.com/problems/find-the-n-th-value-after-k-seconds
public class S03179
{
    private const int Mod = 1_000_000_007;

    public int ValueAfterKSeconds(int n, int k)
    {
        var v = Enumerable.Repeat(1, n).ToList();

        while (k-- > 0)
        {
            for (var j = 1; j < n; j++)
            {
                v[j] = (v[j - 1] + v[j]) % Mod;
            }
        }

        return v[n - 1];
    }
}
