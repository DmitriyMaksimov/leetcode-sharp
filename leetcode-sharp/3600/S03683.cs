namespace leetcode_sharp;

// 3683. Earliest Time to Finish One Task
// https://leetcode.com/problems/earliest-time-to-finish-one-task
public class S03683
{
    public int EarliestTime(int[][] tasks)
    {
        return tasks.Min(x => x[0] + x[1]);
    }
}