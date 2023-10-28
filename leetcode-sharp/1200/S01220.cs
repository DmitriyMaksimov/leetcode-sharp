namespace leetcode_sharp;

// 1220. Count Vowels Permutation
// https://leetcode.com/problems/count-vowels-permutation
public class S01220
{
    private const int Mod = 1_000_000_007;

    public int CountVowelPermutation(int n)
    {
        var a = 1L;
        var e = 1L;
        var i = 1L;
        var o = 1L;
        var u = 1L;

        for (var j = 1; j < n; j++)
        {
            var aNext = e;
            var eNext = (a + i) % Mod;
            var iNext = (a + e + o + u) % Mod;
            var oNext = (i + u) % Mod;
            var uNext = a;

            a = aNext;
            e = eNext;
            i = iNext;
            o = oNext;
            u = uNext;
        }

        return (int) ((a + e + i + o + u) % Mod);
    }
}