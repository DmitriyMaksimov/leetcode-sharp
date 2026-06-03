namespace leetcode_sharp;

// 3635. Earliest Finish Time for Land and Water Rides II
// https://leetcode.com/problems/earliest-finish-time-for-land-and-water-rides-ii
public class S03635
{
    public int EarliestFinishTime(int[] landStartTime, int[] landDuration, int[] waterStartTime, int[] waterDuration)
    {
        var earliestLandCompletion = landStartTime.Zip(landDuration, (start, duration) => start + duration).Min();
        var earliestWaterCompletion = waterStartTime.Zip(waterDuration, (start, duration) => start + duration).Min();
        var landThenWater = waterStartTime.Select((waterStart, i) => Math.Max(waterStart, earliestLandCompletion) + waterDuration[i]).Min();
        var waterThenLand = landStartTime.Select((landStart, i) => Math.Max(landStart, earliestWaterCompletion) + landDuration[i]).Min();

        return Math.Min(landThenWater, waterThenLand);
    }
}