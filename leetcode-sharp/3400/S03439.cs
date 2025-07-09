namespace leetcode_sharp;

// 3439. Reschedule Meetings for Maximum Free Time I
// https://leetcode.com/problems/reschedule-meetings-for-maximum-free-time-i
public class S03439
{
    public int MaxFreeTime(int eventTime, int k, int[] startTime, int[] endTime)
    {
        var gap = new int[startTime.Length + 1];
        gap[0] = startTime[0];

        for (var i = 1; i < startTime.Length; ++i)
        {
            gap[i] = startTime[i] - endTime[i - 1];
        }

        gap[startTime.Length] = eventTime - endTime[^1];

        var result = 0;
        var sum = 0;

        for (var i = 0; i < gap.Length; ++i)
        {
            sum += gap[i] - (i >= k + 1 ? gap[i - (k + 1)] : 0);
            result = Math.Max(result, sum);
        }

        return result;
    }
}