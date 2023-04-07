namespace leetcode_sharp;

// 69. Sqrt(x)
// https://leetcode.com/problems/sqrtx/
public class S00069
{
    public int MySqrt(int x)
    {
        var lo = 1;
        var hi = x;
        var result = 0;
        
        while (lo <= hi)
        {
            var mid = lo + (hi - lo) / 2;
            var square = (long)mid * mid;
            if (square == x)
            {
                return mid;
            }

            if (square > x)
            {
                hi = mid - 1;
            }
            else
            {
                lo = mid + 1;
                result = mid;
            }
        }

        return result;
    }
}