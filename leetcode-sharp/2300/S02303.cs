namespace leetcode_sharp;

// 2303. Calculate Amount Paid in Taxes
// https://leetcode.com/problems/calculate-amount-paid-in-taxes/
public class S02303
{
    public double CalculateTax(int[][] brackets, int income)
    {
        var prev = 0;
        var taxes = 0.0;

        foreach (var bracket in brackets)
        {
            if (income <= 0)
            {
                break;
            }

            var diff = Math.Min(bracket[0] - prev, income);

            taxes += diff * (bracket[1] / 100.0);

            income -= diff;
            prev = bracket[0];
        }

        return taxes;
    }
}