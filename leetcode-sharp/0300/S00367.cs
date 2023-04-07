namespace leetcode_sharp._0300;

// 367. Valid Perfect Square
// https://leetcode.com/problems/valid-perfect-square/
public class S00367
{
    public bool IsPerfectSquare(int num)
    {
        var lo = 1;
        var hi = num;
        
        while (lo <= hi)
        {
            var mid = lo + (hi - lo) / 2;
            var square = (long)mid * mid;
            if (square == num)
            {
                return true;
            }

            if (square > num)
            {
                hi = mid - 1;
            }
            else
            {
                lo = mid + 1;
            }
        }

        return false;
    }
}