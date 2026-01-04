namespace leetcode_sharp;

// 1411. Number of Ways to Paint N × 3 Grid
// https://leetcode.com/problems/number-of-ways-to-paint-n-3-grid
public class S01411
{
    private const int Mod = 1_000_000_007;

    public int NumOfWays(int n)
    {
        var a = 6L; // Type A: all different
        var b = 6L; // Type B: top & bottom same

        for (var i = 2; i <= n; i++)
        {
            var newA = (2 * a + 2 * b) % Mod;
            var newB = (2 * a + 3 * b) % Mod;

            a = newA;
            b = newB;
        }

        return (int)((a + b) % Mod);
    }
}