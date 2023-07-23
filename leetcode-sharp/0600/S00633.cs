namespace leetcode_sharp;

// 633. Sum of Square Numbers
// https://leetcode.com/problems/sum-of-square-numbers/
public class S00633
{
    public bool JudgeSquareSum(int c)
    {
        var lo = 0L;
        var hi = (long)Math.Sqrt(c);

        while (lo <= hi)
        {
            var sum = lo * lo + hi * hi;
            if (sum == c)
            {
                return true;
            }

            if (sum > c)
            {
                --hi;
            }
            else
            {
                ++lo;
            }
        }
        
        return false;
    }
}