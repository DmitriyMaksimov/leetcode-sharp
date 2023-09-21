namespace leetcode_sharp;

// 2335. Minimum Amount of Time to Fill Cups
// https://leetcode.com/problems/minimum-amount-of-time-to-fill-cups/
public class S02335
{
    public int FillCups(int[] amount)
    {
        var seconds = 0;

        while (amount.Sum() > 0)
        {
            // Sort the amounts in decreasing order
            Array.Sort(amount, (a, b) => b - a);

            // If we have at least two types of cups to fill, fill two cups of different types
            if (amount[1] > 0)
            {
                amount[0]--;
                amount[1]--;
                seconds++;
            }
            else
            {
                // If we only have one type of cup to fill, fill one cup of any type for each remaining second
                seconds += amount[0];
                break;
            }
        }

        return seconds;
    }
}