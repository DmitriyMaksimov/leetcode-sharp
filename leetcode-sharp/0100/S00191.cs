namespace leetcode_sharp;

// 191. Number of 1 Bits
// https://leetcode.com/problems/number-of-1-bits/
public class S00191
{
    public int HammingWeight(uint n)
    {
        var count = 0;
        while (n != 0)
        {
            if ((n & 1) != 0) ++count;
            n >>= 1;
        }

        return count;
    }
}