namespace leetcode_sharp;

// 1015. Smallest Integer Divisible by K
// https://leetcode.com/problems/smallest-integer-divisible-by-k
public class S01015
{
    public int SmallestRepunitDivByK(int k)
    {
        if (k % 2 == 0 || k % 5 == 0)
        {
            return -1;
        }

        var reminder = 0;
        
        for (var n = 1; n <= k; ++n)
        {
            reminder = (reminder * 10 + 1) % k;

            if (reminder == 0)
            {
                return n;
            }
        }

        return -1;
    }
}