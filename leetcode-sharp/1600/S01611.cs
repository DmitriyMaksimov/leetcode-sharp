namespace leetcode_sharp;

// 1611. Minimum One Bit Operations to Make Integers Zero
// https://leetcode.com/problems/minimum-one-bit-operations-to-make-integers-zero
public class S01611
{
    public int MinimumOneBitOperations(int n)
    {
        var sign = 1;
        var result = 0;
        
        while (n > 0)
        {
            result += n ^ (n - 1) * sign;
            n &= n - 1;
            sign = -sign;
        }

        return Math.Abs(result);
    }
}