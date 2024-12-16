namespace leetcode_sharp;

// 2365. Task Scheduler II
// https://leetcode.com/problems/task-scheduler-ii
public class S02365
{
    public long TaskSchedulerII(int[] tasks, int space)
    {
        Dictionary<int, long> m = [];
        var currentDay = 0L;

        foreach (var task in tasks)
        {
            ++currentDay;

            if (m.TryGetValue(task, out var value) && currentDay - value <= space)
            {
                currentDay += space - (currentDay - value) + 1;
            }

            m[task] = currentDay;
        }

        return currentDay;
    }
}
