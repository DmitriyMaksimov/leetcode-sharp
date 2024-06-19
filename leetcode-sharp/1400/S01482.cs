namespace leetcode_sharp;

// 1482. Minimum Number of Days to Make m Bouquets
// https://leetcode.com/problems/minimum-number-of-days-to-make-m-bouquets
public class S01482
{
    public int MinDays(int[] bloomDay, int m, int k)
    {
        if (bloomDay.Length < (long)m * k)
        {
            return -1;
        }

        var min = int.MaxValue;
        var max = int.MinValue;
        foreach (var i in bloomDay)
        {
            max = Math.Max(max, i);
            min = Math.Min(min, i);
        }

        while (min < max)
        {
            var mid = min + (max - min) / 2;
            var possibleBookies = GetPossibleBouquets(bloomDay, mid, k);

            if (possibleBookies < m)
            {
                min = mid + 1;
            }
            else
            {
                max = mid;
            }
        }

        return min;
    }

    private static int GetPossibleBouquets(int[] bloomDay, int day, int k)
    {
        var bouquets = 0;
        var flowersCollected = 0;

        foreach (var value in bloomDay)
        {
            if (value <= day)
            {
                flowersCollected++;
            }
            else
            {
                flowersCollected = 0;
            }

            if (flowersCollected == k)
            {
                bouquets++;
                flowersCollected = 0;
            }
        }

        return bouquets;
    }
}