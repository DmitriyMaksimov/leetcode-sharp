namespace leetcode_sharp;

// 2391. Minimum Amount of Time to Collect Garbage
// https://leetcode.com/problems/minimum-amount-of-time-to-collect-garbage
public class S02391
{
    public int GarbageCollection(string[] garbage, int[] travel)
    {
        var last = new int[128];
        var res = 0;

        for (var i = 0; i < garbage.Length; ++i)
        {
            res += garbage[i].Length;
            for (var j = 0; j < garbage[i].Length; ++j)
            {
                last[garbage[i][j]] = i;
            }
        }

        for (var j = 1; j < travel.Length; ++j)
        {
            travel[j] += travel[j - 1];
        }

        res += "PGM".ToCharArray().Where(c => last[c] > 0).Sum(c => travel[last[c] - 1]);

        return res;
    }
}