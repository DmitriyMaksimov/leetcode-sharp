namespace leetcode_sharp;

// 495. Teemo Attacking
// https://leetcode.com/problems/teemo-attacking/
public class S00495
{
    public int FindPoisonedDuration(int[] timeSeries, int duration)
    {
        var result = 0;
        for (var i = 0; i < timeSeries.Length; i++)
        {
            if (i == timeSeries.Length - 1)
            {
                result += duration;
            }
            else
            {
                result += Math.Min(timeSeries[i + 1] - timeSeries[i], duration);
            }
        }

        return result;
    }
}