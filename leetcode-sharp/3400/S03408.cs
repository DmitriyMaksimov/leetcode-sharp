namespace leetcode_sharp;

// 3408. Design Task Manager
// https://leetcode.com/problems/design-task-manager
public class S03408
{
public class TaskManager
{
    private readonly PriorityQueue<(int Priority, int TaskId), (int Priority, int TaskId)> _pq;
    private readonly Dictionary<int, int> _taskPriority = new();
    private readonly Dictionary<int, int> _taskOwner = new();

    public TaskManager(IList<IList<int>> tasks)
    {
        _pq = new PriorityQueue<(int, int), (int, int)>(Comparer<(int, int)>.Create((a, b) => a.Item1 != b.Item1 ? b.Item1.CompareTo(a.Item1) : b.Item2.CompareTo(a.Item2)));

        foreach (var t in tasks)
        {
            if (t.Count == 3)
            {
                Add(t[0], t[1], t[2]);
            }
        }
    }

    public void Add(int userId, int taskId, int priority)
    {
        _pq.Enqueue((priority, taskId), (priority, taskId));
        _taskPriority[taskId] = priority;
        _taskOwner[taskId] = userId;
    }

    public void Edit(int taskId, int newPriority)
    {
        _pq.Enqueue((newPriority, taskId), (newPriority, taskId));
        _taskPriority[taskId] = newPriority;
    }

    public void Rmv(int taskId)
    {
        _taskPriority[taskId] = -1;
    }

    public int ExecTop()
    {
        while (_pq.Count > 0)
        {
            var (priority, taskId) = _pq.Dequeue();
            if (_taskPriority.TryGetValue(taskId, out var curr) && curr == priority && curr >= 0)
            {
                _taskPriority[taskId] = -1;
                return _taskOwner[taskId];
            }
        }

        return -1;
    }
}
}