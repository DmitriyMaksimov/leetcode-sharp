namespace leetcode_sharp;

// 1834. Single-Threaded CPU
// https://leetcode.com/problems/single-threaded-cpu/
public class S01834
{
    private readonly PriorityQueue<int, (int enqueueTime, int processingTime, int index)> _tasksByEnqueueTime = new();
    private readonly PriorityQueue<int, (int processingTime, int index)> _readyForExecution = new();
    private int[][] _tasks = null!;

    public int[] GetOrder(int[][] tasks)
    {
        _tasks = tasks;

        for (var i = 0; i < tasks.Length; ++i)
        {
            var task = tasks[i];
            var (enqueueTime, processingTime) = (task[0], task[1]);
            var priority = (enqueueTime, processingTime, i);
            _tasksByEnqueueTime.Enqueue(i, priority);
        }

        var currentCpuCycle = 1;

        var result = new List<int>(tasks.Length);

        while (true)
        {
            findReadyToExecuteTasks(currentCpuCycle);

            if (_readyForExecution.Count > 0)
            {
                // We have tasks => execute first one
                var index = _readyForExecution.Dequeue();
                var task = tasks[index];
                var (enqueueTime, processingTime) = (task[0], task[1]);
                currentCpuCycle += processingTime;
                result.Add(index);
            }
            else
            {
                // No tasks to execute => idle until first task
                if (_tasksByEnqueueTime.Count == 0)
                {
                    // All tasks processed
                    break;
                }
                var index = _tasksByEnqueueTime.Peek();
                var task = tasks[index];
                var (enqueueTime, processingTime) = (task[0], task[1]);
                currentCpuCycle = enqueueTime;
            }
        }

        return result.ToArray();
    }

    private void findReadyToExecuteTasks(int currentCpuCycle)
    {
        while (_tasksByEnqueueTime.Count > 0)
        {
            var index = _tasksByEnqueueTime.Peek();
            var task = _tasks[index];
            var (enqueueTime, processingTime) = (task[0], task[1]);
            if (enqueueTime > currentCpuCycle)
            {
                break;
            }

            _readyForExecution.Enqueue(index, (processingTime, index));
            _tasksByEnqueueTime.Dequeue();
        }
    }
}