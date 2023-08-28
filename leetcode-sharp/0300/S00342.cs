namespace leetcode_sharp;

// 342. Power of Four
// https://leetcode.com/problems/power-of-four/
public class S00342
{
    public bool IsPowerOfFour(int n)
    {
        if (n <= 0)
        {
            return false;
        }

        while (n % 4 == 0)
        {
            n /= 4;
        }

        return n == 1;
    }
}