namespace leetcode_sharp;

// 1009. Complement of Base 10 Integer
// https://leetcode.com/problems/complement-of-base-10-integer/
public class S01009
{
    public int BitwiseComplement(int n)
    {
        if (n == 0)
        {
            return 1;
        }

        var mask = 1;
        while (mask <= n)
        {
            mask <<= 1;
        }

        return (mask - 1) ^ n;
    }
}