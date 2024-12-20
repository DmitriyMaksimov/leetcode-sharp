namespace leetcode_sharp;

// 371. Sum of Two Integers
// https://leetcode.com/problems/sum-of-two-integers
public class S00371
{
    public int GetSum(int a, int b)
    {
        while (b != 0)
        {
             var carry = a & b;

            a ^= b;
            b = carry << 1;
        }

        return a;
    }
}
