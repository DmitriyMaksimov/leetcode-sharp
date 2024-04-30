namespace leetcode_sharp;

// 1915. Number of Wonderful Substrings
// https://leetcode.com/problems/number-of-wonderful-substrings
public class S01915
{
    public long WonderfulSubstrings(string word)
    {
        var cnt = new long[1024];
        var res = 0L;
        var mask = 0;
        cnt[0] = 1;

        foreach (var ch in word)
        {
            mask ^= 1 << (ch - 'a');
            res += cnt[mask];

            for (var n = 0; n < 10; ++n)
            {
                res += cnt[mask ^ (1 << n)];
            }

            ++cnt[mask];
        }

        return res;
    }
}