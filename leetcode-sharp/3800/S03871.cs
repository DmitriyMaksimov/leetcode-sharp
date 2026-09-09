namespace leetcode_sharp;

// 3871. Count Commas in Range II
// https://leetcode.com/problems/count-commas-in-range-ii
public class S03871
{
    private static long[] pow1000 = [1000L, 1000000L, 1000000000L, 1000000000000L, 1000000000000000L, 1000000000000000000L];

    public long CountCommas(long n)
    {
        var k = pow1000.Count(pow => n >= pow);

        return k * (n + 1) - (pow1000[k] - 1000) / 999;
    }
}