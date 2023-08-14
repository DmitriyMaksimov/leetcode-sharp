namespace leetcode_sharp;

// 172. Factorial Trailing Zeroes
// https://leetcode.com/problems/factorial-trailing-zeroes/
public class S00172
{
    public int TrailingZeroes(int n)
    {
        var result = 0;

        while (n >= 5)
        {
            n /= 5;
            result += n;
        }

        return result;
    }
}