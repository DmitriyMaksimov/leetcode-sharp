namespace leetcode_sharp;

// 1716. Calculate Money in Leetcode Bank
// https://leetcode.com/problems/calculate-money-in-leetcode-bank/
public class S01716
{
    public int TotalMoney(int n)
    {
        var weeks = n / 7;
        var days = n % 7;
        var sum = 0;

        for (var i = 0; i < weeks; i++)
        {
            sum += 28 + i * 7;
        }

        for (var i = 0; i < days; i++)
        {
            sum += weeks + i + 1;
        }

        return sum;
    }
}