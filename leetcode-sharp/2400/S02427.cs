namespace leetcode_sharp;

// 2427. Number of Common Factors
// https://leetcode.com/problems/number-of-common-factors/
public class S02427
{
    public int CommonFactors(int a, int b)
    {
        var n = Math.Min(a, b);
        var result = 0;

        for (var i = 1; i <= n; i++)
        {
            if (a % i == 0 && b % i == 0)
            {
                ++result;
            }
        }

        return result;
    }
}