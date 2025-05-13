namespace leetcode_sharp;

// 3335. Total Characters in String After Transformations I
// https://leetcode.com/problems/total-characters-in-string-after-transformations-i
public class S03335
{
    private const long Mod = 1_000_000_007;

    public int LengthAfterTransformations(string s, int t)
    {
        const int maxLaters = 26;

        var nums = new long[maxLaters];
        foreach (var ch in s)
        {
            nums[ch - 'a']++;
        }

        while (t-- > 0)
        {
            var cur = new long[maxLaters];
            for (var j = 0; j < maxLaters; j++)
            {
                if (j == maxLaters - 1 && nums[j] > 0)
                {
                    cur[0] = ModAdd(cur[0], nums[j]);
                    cur[1] = ModAdd(cur[1], nums[j]);
                }
                else if (j < maxLaters - 1)
                {
                    cur[j + 1] = ModAdd(cur[j + 1], nums[j]);
                }
            }

            nums = cur;
        }

        return (int)nums.Aggregate(0L, ModAdd);
    }

    private static long ModAdd(long a, long b)
    {
        a %= Mod;
        b %= Mod;
        return ((a + b) % Mod + Mod) % Mod;
    }
}
