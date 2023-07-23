namespace leetcode_sharp;

// 2651. Calculate Delayed Arrival Time
// https://leetcode.com/problems/calculate-delayed-arrival-time/
public class S02651
{
    public int FindDelayedArrivalTime(int arrivalTime, int delayedTime)
    {
        return (arrivalTime + delayedTime) % 24;
    }
}