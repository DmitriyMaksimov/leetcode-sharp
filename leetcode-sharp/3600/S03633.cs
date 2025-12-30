namespace leetcode_sharp;

// 3633. Earliest Finish Time for Land and Water Rides I
// https://leetcode.com/problems/earliest-finish-time-for-land-and-water-rides-i
public class S03633
{
    public int EarliestFinishTime(int[] landStartTime, int[] landDuration, int[] waterStartTime, int[] waterDuration)
    {
        var option1 = Calc(landStartTime, landDuration, waterStartTime, waterDuration);
        var option2 = Calc(waterStartTime, waterDuration, landStartTime, landDuration);

        return Math.Min(option1, option2);
    }

    private static int Calc(int[] start1, int[] dur1, int[] start2, int[] dur2)
    {
        var minFinish = start1.Select((t, i) => t + dur1[i]).Min();

        return start2.Select(t => Math.Max(minFinish, t)).Select((start, j) => start + dur2[j]).Min();
    }
}