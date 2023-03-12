namespace leetcode_sharp;

// 343. Integer Break
// https://leetcode.com/problems/integer-break/
public class S00343
{
    public int IntegerBreak(int n)
    {
        if (n is 2 or 3)
        {
            return n - 1;
        }

        // Use as many 3 as we can
        var res = 1;
        while (n > 4)
        {
            n -= 3;
            res *= 3;
        }

        return n * res;
    }
}