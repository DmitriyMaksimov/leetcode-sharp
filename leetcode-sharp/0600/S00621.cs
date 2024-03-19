namespace leetcode_sharp;

// 621. Task Scheduler
// https://leetcode.com/problems/task-scheduler
public class S00621
{
    public int LeastInterval(char[] tasks, int n)
    {
        Dictionary<char, int> frequencies = [];

        foreach (var task in tasks)
        {
            frequencies[task] = frequencies.GetValueOrDefault(task) + 1;
        }

        var maxFrequency = frequencies.Values.Max();
        var answer = (maxFrequency - 1) * (n + 1) + frequencies.Values.Count(value => value == maxFrequency);

        return Math.Max(tasks.Length, answer);
    }
}