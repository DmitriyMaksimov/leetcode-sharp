namespace leetcode_sharp;

// 201. Bitwise AND of Numbers Range
// https://leetcode.com/problems/bitwise-and-of-numbers-range/
public class S00201
{
    public int RangeBitwiseAnd(int left, int right)
    {
        while (right > left)
        {
            right &= right - 1;
        }

        return left & right;
    }
}