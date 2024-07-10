namespace leetcode_sharp;

// 1701. Average Waiting Time
// https://leetcode.com/problems/average-waiting-time
public class S01701
{
    public double AverageWaitingTime(int[][] customers)
    {
        var totalWaitTime = 0.0;
        var current = 0.0;

        foreach (var customer in customers)
        {
            current = Math.Max(current, 1.0 * customer[0]) + customer[1];
            totalWaitTime += current - customer[0];
        }

        return 1.0 * totalWaitTime / customers.Length;
    }
}