namespace leetcode_sharp;

// 790. Domino and Tromino Tiling
// https://leetcode.com/problems/domino-and-tromino-tiling
public class S00790
{
    public int NumTilings(int n)
    {
        const int mod = 1_000_000_007;
        var a = 0;
        var b = 1;
        var c = 1;

        while (--n > 0)
        {
            var newC = (c * 2 % mod + a) % mod;
            a = b;
            b = c;
            c = newC;
        }

        return c;
    }
}
