namespace leetcode_sharp;

// 3169. Count Days Without Meetings
// https://leetcode.com/problems/count-days-without-meetings
public class S03169
{
    public int CountDays(int days, int[][] meetings)
    {
        if (meetings.Length == 0)
        {
            return days;
        }

        Array.Sort(meetings, (a, b) => a[0].CompareTo(b[0]));

        var mergedBusyDays = 0;
        var start = meetings[0][0];
        var end = meetings[0][1];

        foreach (var meeting in meetings)
        {
            if (meeting[0] <= end)
            {
                end = Math.Max(end, meeting[1]);
            }
            else
            {
                mergedBusyDays += end - start + 1;
                start = meeting[0];
                end = meeting[1];
            }
        }

        mergedBusyDays += end - start + 1;

        return days - mergedBusyDays;
    }
}
