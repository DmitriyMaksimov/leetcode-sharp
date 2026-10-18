namespace leetcode_sharp;

// 3986. Number of Elapsed Seconds Between Two Times
// https://leetcode.com/problems/number-of-elapsed-seconds-between-two-times
public class S03986
{
    public int SecondsBetweenTimes(string startTime, string endTime)
    {
        return (int)((TimeSpan.Parse(endTime) - TimeSpan.Parse(startTime)).TotalSeconds);
    }
}