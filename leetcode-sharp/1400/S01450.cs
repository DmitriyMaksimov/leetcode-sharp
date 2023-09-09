namespace leetcode_sharp;

// 1450. Number of Students Doing Homework at a Given Time
// https://leetcode.com/problems/number-of-students-doing-homework-at-a-given-time/
public class S01450
{
    public int BusyStudent(int[] startTime, int[] endTime, int queryTime)
    {
        return startTime.Where((t, i) => t <= queryTime && queryTime <= endTime[i]).Count();
    }
}