namespace leetcode_sharp;

// 3440. Reschedule Meetings for Maximum Free Time II
// https://leetcode.com/problems/reschedule-meetings-for-maximum-free-time-ii
public class S03440
{
    public int MaxFreeTime(int eventTime, int[] startTime, int[] endTime)
    {
        var n = startTime.Length;
        var result = 0;
        var t1 = 0;
        var t2 = 0;

        for (var i = 0; i < n; i++)
        {
            var left = i == 0 ? 0 : endTime[i - 1];
            var right = i == n - 1 ? eventTime : startTime[i + 1];

            if (endTime[i] - startTime[i] <= t1)
            {
                result = Math.Max(result, right - left);
            }

            t1 = Math.Max(t1, startTime[i] - (i == 0 ? 0 : endTime[i - 1]));

            result = Math.Max(result, right - left - (endTime[i] - startTime[i]));

            var left2 = i == n - 1 ? 0 : endTime[n - i - 2];
            var right2 = i == 0 ? eventTime : startTime[n - i];

            if (endTime[n - i - 1] - startTime[n - i - 1] <= t2)
            {
                result = Math.Max(result, right2 - left2);
            }

            t2 = Math.Max(t2, (i == 0 ? eventTime : startTime[n - i]) - endTime[n - i - 1]);
        }

        return result;
    }
}