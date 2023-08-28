namespace leetcode_sharp;

// 326. Power of Three
// https://leetcode.com/problems/power-of-three/
public class S00326
{
    public bool IsPowerOfThree(int n)
    {
        if (n < 1) return false;

        while (n % 3 == 0)
        {
            n /= 3;
        }

        return n == 1;
    }
}