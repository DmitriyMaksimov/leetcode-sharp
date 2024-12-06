namespace leetcode_sharp;

// 991. Broken Calculator
// https://leetcode.com/problems/broken-calculator
public class S00991
{
    public int BrokenCalc(int startValue, int target)
    {
        var result = 0;

        while (target > startValue)
        {
            result++;

            if (target % 2 == 0)
            {
                target /= 2;
            }
            else
            {
                target++;
            }
        }

        result += startValue - target;

        return result;
    }
}
