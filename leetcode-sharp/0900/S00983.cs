namespace leetcode_sharp;

// 983. Minimum Cost For Tickets
// https://leetcode.com/problems/minimum-cost-for-tickets/
public class S00983
{
    public int MincostTickets(int[] days, int[] costs)
    {
        var travelDays = days.ToHashSet();
        var dp = new int[366];

        for (var i = 1; i < 366; ++i)
        {
            if (!travelDays.Contains(i))
            {
                // If we don't need to travel this day, set the cost the same as previous day
                dp[i] = dp[i - 1];
            }
            else
            {
                // Take minimum of 1 day, 7 days and 30 days tickets
                dp[i] = Math.Min(Math.Min(dp[i - 1] + costs[0], dp[Math.Max(0, i - 7)] + costs[1]), dp[Math.Max(0, i - 30)] + costs[2]);
            }
        }

        return dp.Last();
    }
}