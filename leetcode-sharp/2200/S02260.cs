namespace leetcode_sharp;

// 2260. Minimum Consecutive Cards to Pick Up
// https://leetcode.com/problems/minimum-consecutive-cards-to-pick-up
public class S02260
{
    public int MinimumCardPickup(int[] cards)
    {
        var cardIndices = new Dictionary<int, int>();
        var minimumDistance = int.MaxValue;

        for (var i = 0; i < cards.Length; i++)
        {
            if (cardIndices.TryGetValue(cards[i], out var index))
            {
                minimumDistance = Math.Min(i - index + 1, minimumDistance);
            }

            cardIndices[cards[i]] = i;
        }

        return minimumDistance == int.MaxValue ? -1 : minimumDistance;
    }
}
