namespace leetcode_sharp;

// 190. Reverse Bits
// https://leetcode.com/problems/reverse-bits/
public class S00190
{
    public int ReverseBits(int n)
    {
        var result = 0u;
        var powerOfTwo = 0b10000000000000000000000000000000u;

        while (n != 0)
        {
            if ((n & 1) == 1)
            {
                result |= powerOfTwo;
            }

            n >>= 1;
            powerOfTwo >>= 1;
        }

        return (int)result;
    }
}