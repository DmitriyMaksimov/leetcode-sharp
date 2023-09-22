namespace leetcode_sharp;

// 2347. Best Poker Hand
// https://leetcode.com/problems/best-poker-hand/
public class S02347
{
    public string BestHand(int[] ranks, char[] suits)
    {
        if (suits.All(s => s == suits[0]))
        {
            return "Flush";
        }

        var rankCounts = new Dictionary<int, int>();

        foreach (var rank in ranks)
        {
            rankCounts.TryAdd(rank, 0);
            rankCounts[rank]++;
        }

        if (rankCounts.Values.Any(count => count >= 3))
        {
            return "Three of a Kind";
        }

        return rankCounts.Values.Any(count => count >= 2) ? "Pair" : "High Card";
    }
}