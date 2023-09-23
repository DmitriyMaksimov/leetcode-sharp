namespace leetcode_sharp;

// 2446. Determine if Two Events Have Conflict
// https://leetcode.com/problems/determine-if-two-events-have-conflict/
public class S02446
{
    public bool HaveConflict(string[] event1, string[] event2)
    {
        var start1 = convertTimeToInt(event1[0]);
        var end1 = convertTimeToInt(event1[1]);
        var start2 = convertTimeToInt(event2[0]);
        var end2 = convertTimeToInt(event2[1]);

        return (start1 >= start2 && start1 <= end2) || (start2 >= start1 && start2 <= end1);
    }

    private static int convertTimeToInt(string time)
    {
        var splitTime = time.Split(':');
        return int.Parse(splitTime[0]) * 60 + int.Parse(splitTime[1]);
    }
}