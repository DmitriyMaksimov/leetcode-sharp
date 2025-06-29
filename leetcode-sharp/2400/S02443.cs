namespace leetcode_sharp;

// 2443. Sum of Number and Its Reverse
// https://leetcode.com/problems/sum-of-number-and-its-reverse
public class S02443
{
    public bool SumOfNumberAndReverse(int num)
    {
        if (num == 0)
        {
            return true;
        }

        for (var i = num - 1; i >= num / 2; i--)
        {
            if (i + CalculateReverse(i) == num)
            {
                return true;
            }
        }
        
        return false;
    }

    private static int CalculateReverse(int i)
    {
        var result = 0;

        while (i > 0)
        {
            result = result * 10 + i % 10;
            i /= 10;
        }
        
        return result;
    }
}