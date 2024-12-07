namespace leetcode_sharp;

// 3370. Smallest Number With All Set Bits
// https://leetcode.com/problems/smallest-number-with-all-set-bits
public class S03370
{
    public int SmallestNumber(int n)
    {
        var powerOf2 = 2;

        while (powerOf2 <= n)
        {
            powerOf2 *= 2;
        }

        return powerOf2 - 1;
    }
}
