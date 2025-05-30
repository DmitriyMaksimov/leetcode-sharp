namespace leetcode_sharp;

// 2895. Minimum Processing Time
// https://leetcode.com/problems/minimum-processing-time
public class S02895
{
    public int MinProcessingTime(IList<int> processorTime, IList<int> tasks)
    {
        var orderedProcessorTime = processorTime.Order().ToList();
        var orderedTasks = tasks.OrderDescending().ToList();

        var time = 0;

        for (var i = 0; i < tasks.Count; i++)
        {
            var pTime = orderedProcessorTime[i / 4];
            var timeTaken = pTime + orderedTasks[i];
            time = Math.Max(timeTaken, time);
        }

        return time;
    }
}
