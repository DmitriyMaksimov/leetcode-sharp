namespace leetcode_sharp;

// 1680. Concatenation of Consecutive Binary Numbers
// https://leetcode.com/problems/concatenation-of-consecutive-binary-numbers
public class S01680
{
    public int ConcatenatedBinary(int n)
    {
        const long modulo = 1_000_000_007L;
        var result = 0L;
        var binaryDigits = 0;

        for (var i = 1; i <= n; i++)
        {
            // Bits trick - check if `i` is a power of 2
            if ((i & (i - 1)) == 0)
            {
                binaryDigits++;
            }

            result = ((result << binaryDigits) + i) % modulo;
        }

        return (int)result;
    }
}
