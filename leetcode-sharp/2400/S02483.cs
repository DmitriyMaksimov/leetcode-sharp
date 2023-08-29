namespace leetcode_sharp;

// 2483. Minimum Penalty for a Shop
// https://leetcode.com/problems/minimum-penalty-for-a-shop/
public class S02483
{
    public int BestClosingTime(string customers)
    {
        (int hour, int penalty) best = (customers.Length, customers.Count(c => c == 'N'));
        var penalty = best.penalty;
        
        for (var hour = customers.Length - 1; hour >= 0; hour--)
        {
            penalty += customers[hour] == 'Y' ? 1 : -1;
            if (penalty <= best.penalty)
            {
                best = (hour, penalty);
            }
        }

        return best.hour;
    }
}