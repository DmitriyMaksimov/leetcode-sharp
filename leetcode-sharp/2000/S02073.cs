namespace leetcode_sharp;

// 2073. Time Needed to Buy Tickets
// https://leetcode.com/problems/time-needed-to-buy-tickets/
public class S02073
{
    public int TimeRequiredToBuy(int[] tickets, int k)
    {
        var amount = 0;
        var amountToRemove = 0;
        
        for (var i = 0; i < tickets.Length; i++)
        {
            if (tickets[k] <= tickets[i])
            {
                if (i > k)
                {
                    amountToRemove++;
                }

                amount += tickets[k];
            }
            else
            {
                amount += tickets[i];
            }
        }

        return amount - amountToRemove;
    }
}