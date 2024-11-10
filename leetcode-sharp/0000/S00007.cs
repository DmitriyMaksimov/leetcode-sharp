namespace leetcode_sharp;

// 7. Reverse Integer
// https://leetcode.com/problems/reverse-integer
public class S00007
{
    public int Reverse(int x)
    {
        var sign = x < 0 ? -1 : 1;

        if (sign < 0)
        {
            if (x != int.MinValue)
            {
                x = -x;
            }
            else
            {
                return 0;
            }
        }

        long result = 0;

        while (x > 0)
        {
            result = result * 10 + x % 10;
            x /= 10;
        }

        result *= sign;

        if (result is <= int.MinValue or >= int.MaxValue)
        {
            return 0;
        }

        return (int)result;
    }
}
