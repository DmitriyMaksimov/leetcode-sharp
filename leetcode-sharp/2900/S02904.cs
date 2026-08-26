namespace leetcode_sharp;

// 2904. Shortest and Lexicographically Smallest Beautiful String
// https://leetcode.com/problems/shortest-and-lexicographically-smallest-beautiful-string
public class S02904
{
    public string ShortestBeautifulSubstring(string s, int k)
    {
        var n = s.Length;
        var start = n;
        var current = UInt128.Zero;
        var best = UInt128.MaxValue;
        var found = false;

        for (var i = 0; i < n; i++)
        {
            current = (current << 1) | (UInt128)(s[i] - '0');

            k -= s[i] - '0';

            if (k < 0)
            {
                k = 0;

                var width = BitWidth(current);
                current &= (UInt128.One << (width - 1)) - 1;
            }

            if (k == 0 && (!found || current < best))
            {
                start = i - BitWidth(current) + 1;
                best = current;
                found = true;
            }
        }

        return !found ? "" : s.Substring(start, BitWidth(best));
    }

    private static int BitWidth(UInt128 x)
    {
        if (x == 0)
        {
            return 0;
        }

        var hi = (ulong)(x >> 64);

        if (hi != 0)
        {
            return 128 - System.Numerics.BitOperations.LeadingZeroCount(hi);
        }

        var lo = (ulong)x;
        return 64 - System.Numerics.BitOperations.LeadingZeroCount(lo);
    }
}