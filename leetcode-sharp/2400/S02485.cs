namespace leetcode_sharp;

// 2485. Find the Pivot Integer
// https://leetcode.com/problems/find-the-pivot-integer/
public class S02485
{
    public int PivotInteger(int n)
    {
        var totalSum = n * (n + 1) / 2;
        var sumRight = 0;

        for (var i = 1; i <= n; i++)
        {
            sumRight += i;
            if (totalSum - sumRight + i == sumRight)
            {
                return i;
            }
        }

        return -1;
    }
}