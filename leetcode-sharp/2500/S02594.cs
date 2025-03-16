namespace leetcode_sharp;

// 2594. Minimum Time to Repair Cars
// https://leetcode.com/problems/minimum-time-to-repair-cars
public class S02594
{
    public long RepairCars(int[] ranks, int cars)
    {
        var maxRank = ranks.Max();
        var low = 0L;
        var high = 1L * maxRank * cars * cars;

        while (low < high)
        {
            var time = low + (high - low) / 2;

            if (CanComplete(ranks, cars, time))
            {
                high = time;
            }
            else
            {
                low = time + 1;
            }
        }

        return low;
    }

    private static bool CanComplete(int[] ranks, int cars, long time)
    {
        var finishTime = 0L;

        foreach (var rank in ranks)
        {
            finishTime += (int)Math.Floor(Math.Sqrt(time / rank));

            if (finishTime >= cars)
            {
                return true;
            }
        }

        return false;
    }
}
